using AutoMapper;
using JPSAGE_ERP.Application.Enums;
using JPSAGE_ERP.Application.Helpers;
using JPSAGE_ERP.Application.Interfaces;
using JPSAGE_ERP.Application.Models.Miscellaneous;
using JPSAGE_ERP.Application.Models.SiteReporting;
using JPSAGE_ERP.Domain;
using JPSAGE_ERP.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JPSAGE_ERP.Application.Repository
{
    public class SiteReportRepository : Repository<TblStaffBioData>, ISiteReportRepository
    {
        private readonly IMapper _mapper;
        public SiteReportRepository(ApplicationDbContext context, IMapper mapper)
            : base(context)
        {
            _mapper = mapper;
        }

        public async Task<IEnumerable<TSrconstructionTechnicalQueriesTempDto>> GetAllSRCTQRepliesForAttentee(int attendeeId)
        {
            var query = _context.TblSrconstructionTechnicalQueriesTemp
                .Distinct()
                .Where(x => x.Attention == attendeeId &&
                (x.TblSrconstructionTechnicalQueryRepliesTemp
                    .Where(n => n.Ctqid == x.Ctqid && n.InitiatorAcceptance != (int)EInitiatorAcceptance.Approve))
                    .FirstOrDefault() != null);

            var result = query.Select(x => new TSrconstructionTechnicalQueriesTempDto
            {
                Ctqid = x.Ctqid,
                Ctqtitle = x.Ctqtitle
            });

            return await result.ToListAsync();
        }

        public async Task<IEnumerable<TSrconstructionTechnicalQueriesTempDto>> GetAllSRCTQRepliesForInitiator(int staffId)
        {
            var query = _context.TblSrconstructionTechnicalQueriesTemp
                .Distinct()
                .Where(x => x.StaffId == staffId &&
                (x.TblSrconstructionTechnicalQueryRepliesTemp
                    .Where(n => n.Ctqid == x.Ctqid && n.InitiatorAcceptance != (int)EInitiatorAcceptance.Approve))
                    .FirstOrDefault() != null);

            var result = query.Select(x => new TSrconstructionTechnicalQueriesTempDto
            {
                Ctqid = x.Ctqid,
                Ctqtitle = x.Ctqtitle
            });

            return await result.ToListAsync();
        }

        public async Task<IEnumerable<TSrconstructionTechnicalQueriesTempDto>> GetAllSRCTQReplies()
        {
            var query = await _context.TblSrconstructionTechnicalQueryRepliesTemp
                .Select(x => x.Ctqid).ToListAsync();

            var ctq = await _context.TblSrconstructionTechnicalQueriesTemp
                .Where(x => query.Contains(x.Ctqid))
                .Select(x => new TSrconstructionTechnicalQueriesTempDto
                {
                    Ctqid = x.Ctqid,
                    Ctqtitle = x.Ctqtitle
                }).ToListAsync();

            return ctq;
        }

        /// <summary>
        /// This method is to get the checker's and
        /// approver's email address
        /// </summary>
        /// <param name="wfdefId"></param>
        /// <returns></returns>
        public async Task<(string checker, string authorizer)> GetWorkflowApprovers(int wfdefId)
        {
            var staffRole = await _context.TblStaffRoles.FirstOrDefaultAsync(x => x.WfdefId == wfdefId);

            if (staffRole == null)
            {
                throw new ArgumentNullException(nameof(staffRole));
            }

            var checker = await _context.TblStaffBioData.FirstOrDefaultAsync(x => x.StaffId == staffRole.CheckerId);
            var approver = await _context.TblStaffBioData.FirstOrDefaultAsync(x => x.StaffId == staffRole.AuthoriserId);

            if (checker == null || approver == null) throw new ArgumentNullException(nameof(staffRole));

            return (checker.OfficeEmailAddress, approver.OfficeEmailAddress);
        }

        public async Task<IEnumerable<CompanyInfoDto>> GetAllCompanyInfo(string search)
        {
            var query = _context.TblCompanyInfo as IQueryable<TblCompanyInfo>;

            if (!string.IsNullOrEmpty(search))
            {
                query = query.Where(x => x.CompanyName.ToLower().Contains(search.ToUpper()));
            }

            query = query.Select(x => new TblCompanyInfo
            {
                CompanyId = x.CompanyId,
                CompanyName = x.CompanyName
            });

            var result = await query.ToListAsync();

            var dto = _mapper.Map<IEnumerable<CompanyInfoDto>>(result);

            return dto;
        }

        /// <summary>
        /// This method is used to get all CTQs by user
        /// It returns a Paginated list of CTQ Dto objects
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="parameters"></param>
        /// <returns>PagedList of ConstructionTechnicalQueryDto</returns>
        public async Task<PagedList<ConstructionTechnicalQueryDto>> GetAllCTQ(int userId, CtqParameters parameters)
        {
            var queryCtq = _context.TblSrconstructionTechnicalQueriesTemp.Where(x => x.Attention == userId || x.StaffId == userId);

            if (!string.IsNullOrEmpty(parameters.Search))
            {
                queryCtq = queryCtq.Where(x => x.Ctqtitle.Contains(parameters.Search));
            }

            if (parameters.CompanyId != null)
            {
                queryCtq = queryCtq.Where(x => x.CompanyId == parameters.CompanyId);
            }

            var result = queryCtq.OrderByDescending(x => x.CreatedDate).Select(x => new ConstructionTechnicalQueryDto
            {
                CtqId = x.Ctqid,
                ProjectName = x.Project.ProjectName,
                CtqTitle = x.Ctqtitle,
                AttendeeName = $"{x.AttentionNavigation.FirstName} {x.AttentionNavigation.LastName}",
                Status = x.Status != null ? ((EInitiatorAcceptance)x.Status).ToString() : "Open",
                Priority = x.Priority != null  ? ((EPriority)x.Priority).ToString() : "Low",
                CreatedDate = x.CreatedDate,
                IsInitiator = x.StaffId == userId ? true : false
            });

            var ctqDto = await PagedList<ConstructionTechnicalQueryDto>.Create(result, parameters.PageNumber, parameters.PageSize);

            return ctqDto;
        }

        public async Task<TblSrconstructionTechnicalQueryRepliesTemp> GetCTQByIdDescOrder(int ctqId)
        {
            var result = await _context.TblSrconstructionTechnicalQueryRepliesTemp
                .Where(x => x.Ctqid == ctqId)
                .OrderByDescending(x => x.ReplyId)
                .FirstOrDefaultAsync();

            return result;
        }

        public async Task<ConstructionTechnicalQueryRepliesDto> GetCTQByIdIncludeReplies(int ctqId)
        {
            var query = _context.TblSrconstructionTechnicalQueriesTemp
                .Where(x => x.Ctqid == ctqId)
                .Include(x => x.Staff)
                .Include(x => x.AttentionNavigation)
                .Include(x => x.TblSrconstructionTechnicalQueryRepliesTemp)
                .Include(x => x.TblSrconstructionTechnicalQueryAttachmentsTemp);

            var result = await query.Select(x => new ConstructionTechnicalQueryRepliesDto
            {
                CtqId = x.Ctqid,
                ProjectName = x.Project.ProjectName,
                CtqTitle = x.Ctqtitle,
                AttendeeName = $"{x.AttentionNavigation.FirstName} {x.AttentionNavigation.LastName}",
                Status = x.Status != null ? ((EInitiatorAcceptance)x.Status).ToString() : "Open",
                Priority = x.Priority != null ? ((EPriority)x.Priority).ToString() : "Low",
                CreatedDate = x.CreatedDate,
                Country = x.Country.CountryName,
                State = x.State.StateName,
                City = x.City.CityName,
                Description = x.Ctqdescription,
                InitiatorName = $"{x.Staff.FirstName} {x.Staff.LastName}",
                CtqReplies = x.TblSrconstructionTechnicalQueryRepliesTemp.Select(x => new CtqRepliesDto
                {
                    ReplyId = x.ReplyId,
                    InitiatorReply = x.InitiatorReply,
                    InitiatorReplyDate = x.InitiatorReplyDate,
                    AttentionReply = x.AttentionReply,
                    AttentionReplyDate = x.AttentionReplyDate,
                    InitiatorAcceptance = x.InitiatorAcceptance != null ? ((EInitiatorAcceptance)x.InitiatorAcceptance).ToString() : "Open"
                }).ToList()
            }).FirstOrDefaultAsync();

            return result;
        }
    }
}
