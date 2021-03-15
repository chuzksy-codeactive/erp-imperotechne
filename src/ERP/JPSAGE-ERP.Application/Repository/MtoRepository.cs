using AutoMapper;
using JPSAGE_ERP.Application.Enums;
using JPSAGE_ERP.Application.Helpers;
using JPSAGE_ERP.Application.Interfaces;
using JPSAGE_ERP.Application.Models;
using JPSAGE_ERP.Application.Services;
using JPSAGE_ERP.Domain;
using JPSAGE_ERP.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JPSAGE_ERP.Application.Repository
{
    public class MtoRepository : IMtoRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        private readonly IEmailSender _emailSender;
        public MtoRepository(ApplicationDbContext context, IMapper mapper, IEmailSender emailSender)
        {
            _context = context;
            _mapper = mapper;
            _emailSender = emailSender;
        }

        public async Task CreateMaterialTakeOff(MtoDto mto)
        {
            await using var transaction = await _context.Database.BeginTransactionAsync();
            try
            {
                var projectExist = await _context.TblProjects.FindAsync(mto.ProjectId);
                var companyExist = await _context.TblCompanyInfo.FindAsync(mto.CompanyId);
                var clientExist = await _context.TblClients.FindAsync(mto.ClientId);
                var staff = await _context.TblStaffBioData.FirstOrDefaultAsync(x => x.OfficeEmailAddress == mto.CreatedBy);

                if (projectExist == null)
                {
                    await _emailSender.SendEmailAsync(mto.CreatedBy, "MTO failed to submit", $"Project Id: {mto.ProjectId} not found");
                }

                if (companyExist == null)
                {
                    await _emailSender.SendEmailAsync(mto.CreatedBy, "MTO failed to submit", $"Company Id: {mto.CompanyId} not found");
                }

                if (clientExist == null)
                {
                    await _emailSender.SendEmailAsync(mto.CreatedBy, "MTO failed to submit", $"Client Id: {mto.ClientId} not found");
                }

                if (staff == null)
                {
                    await _emailSender.SendEmailAsync(mto.CreatedBy, "MTO failed to submit", $"Statff email: {mto.CreatedBy} not found");
                }

                var mtoEntity = _mapper.Map<TblMtoformsTemp>(mto);
                mtoEntity.CreatedDate = DateTime.UtcNow;

                var genSum = await _context.TblMtoformsTemp.OrderByDescending(x => x.MtoformId).FirstOrDefaultAsync();
                var raisedDate = $"{DateTime.Now.Day}{DateTime.Now.Month}{DateTime.Now.Year}";
                var project = await _context.TblProjects.FindAsync(mto.ProjectId);
                var company = await _context.TblCompanyInfo.FindAsync(mto.CompanyId);
                var companyCode = company != null && company.CompanyCode != null ? company.CompanyCode.ToUpper() : "DGS";

                var genNum = genSum != null ? genSum.MtoformId.ToString("D4") : "0001";
                var docNum = $"{companyCode}/{project.ProjectName.ToUpper() ?? "PRO"}/{"MTO"}/{raisedDate}/{genNum}";

                mtoEntity.DocumentNumber = docNum;
                mtoEntity.CreatedBy = staff.StaffId.ToString();
                await _context.TblMtoformsTemp.AddAsync(mtoEntity);
                await _context.SaveChangesAsync();


                if (mto.DisciplineId == (int)EMtoDiscipline.Civil && mto.MtoCivilDetails.Count > 0)
                {
                    var civils = _mapper.Map<ICollection<TblMtocivilFormDetailsTemp>>(mto.MtoCivilDetails);

                    foreach (var civil in civils)
                    {
                        civil.MtoformId = mtoEntity.MtoformId;
                        civil.CreatedDate = DateTime.UtcNow;

                        await _context.TblMtocivilFormDetailsTemp.AddAsync(civil);
                        await _context.SaveChangesAsync();
                    }
                }

                if (mto.DisciplineId == (int)EMtoDiscipline.Electrical && mto.MtoElectricalDetails.Count > 0)
                {
                    var electricals = _mapper.Map<ICollection<TblMtoelectricalFormDetailsTemp>>(mto.MtoElectricalDetails);

                    foreach (var electrical in electricals)
                    {
                        electrical.MtoformId = mtoEntity.MtoformId;
                        electrical.CreatedDate = DateTime.UtcNow;

                        await _context.TblMtoelectricalFormDetailsTemp.AddAsync(electrical);
                        await _context.SaveChangesAsync();
                    }
                }

                if (mto.DisciplineId == (int)EMtoDiscipline.Instrument && mto.MtoInstrumentDetails.Count > 0)
                {
                    var instruments = _mapper.Map<ICollection<TblMtoinstrumentFormDetailsTemp>>(mto.MtoInstrumentDetails);

                    foreach (var instrument in instruments)
                    {
                        instrument.MtoformId = mtoEntity.MtoformId;
                        instrument.CreatedDate = DateTime.UtcNow;

                        await _context.TblMtoinstrumentFormDetailsTemp.AddAsync(instrument);
                        await _context.SaveChangesAsync();
                    }
                }

                if (mto.DisciplineId == (int)EMtoDiscipline.Piping && mto.MtoPipingDetails.Count > 0)
                {
                    var pipings = _mapper.Map<ICollection<TblMtopipingFormDetailsTemp>>(mto.MtoPipingDetails);

                    foreach (var piping in pipings)
                    {
                        piping.MtoformId = mtoEntity.MtoformId;
                        piping.CreatedDate = DateTime.UtcNow;

                        await _context.TblMtopipingFormDetailsTemp.AddAsync(piping);
                        await _context.SaveChangesAsync();
                    }
                }

                await transaction.CommitAsync();
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                throw;
            }
        }

        public async Task<PagedList<TblMtoformsTemp>> GetAllMaterialTakeOffs(int userId, MtoParameters parameters)
        {
            var query = _context.TblMtoformsTemp.Where(x => x.CreatedBy == userId.ToString());

            if (!string.IsNullOrEmpty(parameters.Search))
            {
                var search = parameters.Search.Trim().ToLower();
                query = query.Where(x => x.Project.ProjectName.ToLower().Contains(search) ||
                    x.Client.ClientName.ToLower().Contains(search) ||
                    x.Company.CompanyName.ToLower().Contains(search) ||
                    x.Discipline.Name.Contains(search) ||
                    x.Title.Contains(search));
            }

            if (parameters.DisciplineId != null)
            {
                query = query.Where(x => x.DisciplineId == parameters.DisciplineId);
            }

            if (parameters.ThisMonth)
            {
                int thisMonth = DateTime.Today.Month;
                query = query.Where(x => x.CreatedDate.Value.Month == thisMonth);
            }

            if (parameters.LastMonth)
            {
                int lastMonth = DateTime.Today.AddMonths(-1).Month;
                query = query.Where(x => x.CreatedDate.Value.Month == lastMonth);
            }

            if (parameters.ThisYear)
            {
                int thisYear = DateTime.Today.Year;
                query = query.Where(x => x.CreatedDate.Value.Year == thisYear);
            }

            if (parameters.ThisWeek)
            {
                var startDate = DateTime.Today;
                startDate = startDate.AddDays(-(((startDate.DayOfWeek - DayOfWeek.Monday) + 7) % 7));

                query = query.Where(x => x.CreatedDate >= startDate);
            }

            var result = query.Select(x => new MtoViewModelDto
            {
                ProjectName = x.Project.ProjectName,
                ProjectNumber = x.DocumentNumber,
                FormType = x.Discipline.Name,
                NoOfItems = GetItemsCount(x.DisciplineId, x.MtoformId),
                Status = "Approved"
            });

            var mtoList = await PagedList<TblMtoformsTemp>.Create(query, parameters.PageNumber, parameters.PageSize);

            return mtoList;
        }

        public async Task<MtoDto> GetMaterialTakeOff(int mtoId)
        {
            var mto = await _context.TblMtoformsTemp.FindAsync(mtoId);

            var mtoDto = _mapper.Map<MtoDto>(mto);

            if (mto.DisciplineId == (int)EMtoDiscipline.Civil)
            {
                var civils = await _context.TblMtocivilFormDetailsTemp.Where(x => x.MtoformId == mtoId).ToListAsync();

                var civilsDto = _mapper.Map<IEnumerable<MtoCivilDetailsDto>>(civils);

                mtoDto.MtoCivilDetails = civilsDto.ToList();
            }

            if (mto.DisciplineId == (int)EMtoDiscipline.Electrical)
            {
                var electrical = await _context.TblMtoelectricalFormDetailsTemp.Where(x => x.MtoformId == mtoId).ToListAsync();

                var electricalsDto = _mapper.Map<IEnumerable<MtoElectricalDetailsDto>>(electrical);

                mtoDto.MtoElectricalDetails = electricalsDto.ToList();
            }

            if (mto.DisciplineId == (int)EMtoDiscipline.Instrument)
            {
                var instruments = await _context.TblMtoinstrumentFormDetailsTemp.Where(x => x.MtoformId == mtoId).ToListAsync();

                var instrumentsDto = _mapper.Map<IEnumerable<MtoInstrumentDetailsDto>>(instruments);

                mtoDto.MtoInstrumentDetails = instrumentsDto.ToList();
            }

            if (mto.DisciplineId == (int)EMtoDiscipline.Piping)
            {
                var pipings = await _context.TblMtopipingFormDetailsTemp.Where(x => x.MtoformId == mtoId).ToListAsync();

                var pipingsDto = _mapper.Map<IEnumerable<MtoPipingDetailsDto>>(pipings);

                mtoDto.MtoPipingDetails = pipingsDto.ToList();
            }

            return mtoDto;
        }

        public async Task<IEnumerable<MtoDisciplineDto>> GetMtoDiscipline()
        {
            var disciplines = await _context.TblMtodiscipline.ToListAsync();

            var result = _mapper.Map<ICollection<MtoDisciplineDto>>(disciplines);

            return result;
        }

        public async Task<IEnumerable<MtoSubdisciplineDto>> GetMtosubDisciplines(int mtoDisciplineId)
        {
            var subDisciplines = await _context.TblMtosubDiscipline.Where(x => x.DisciplineId == mtoDisciplineId).ToListAsync();

            var result = _mapper.Map<ICollection<MtoSubdisciplineDto>>(subDisciplines);

            return result;
        }

        public int GetItemsCount(int disciplineId, int mtoId)
        {
            int items = 0;
            if (disciplineId == (int)EMtoDiscipline.Civil)
            {
                var result = _context.TblMtocivilFormDetailsTemp.Where(x => x.MtoformId == mtoId).ToListAsync();

                items = result.Result.Count;
            }

            if (disciplineId == (int)EMtoDiscipline.Electrical)
            {
                var result = _context.TblMtoelectricalFormDetailsTemp.Where(x => x.MtoformId == mtoId).ToListAsync();

                items = result.Result.Count;
            }

            if (disciplineId == (int)EMtoDiscipline.Instrument)
            {
                var result = _context.TblMtoinstrumentFormDetailsTemp.Where(x => x.MtoformId == mtoId).ToListAsync();

                items = result.Result.Count;
            }

            if (disciplineId == (int)EMtoDiscipline.Piping)
            {
                var result = _context.TblMtopipingFormDetails.Where(x => x.MtoformId == mtoId).ToListAsync();

                items = result.Result.Count;
            }

            return items;
        }
    }
}
