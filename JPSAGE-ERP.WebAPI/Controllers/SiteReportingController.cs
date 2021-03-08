using AutoMapper;
using Hangfire;
using JPSAGE_ERP.Application.Enums;
using JPSAGE_ERP.Application.Helpers;
using JPSAGE_ERP.Application.Interfaces;
using JPSAGE_ERP.Application.Models.Responses;
using JPSAGE_ERP.Application.Models.SiteReporting;
using JPSAGE_ERP.Application.Services;
using JPSAGE_ERP.Domain;
using JPSAGE_ERP.Domain.Entities;
using JPSAGE_ERP.Domain.Enums;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Threading.Tasks;

namespace JPSAGE_ERP.WebAPI.Controllers
{
    /// <summary>
    /// Controller for daily site reporting
    /// </summary>
    [Route("api/v1/sitereports")]
    [Authorize]
    [ApiController]
    public class SiteReportingController : ControllerBase
    {
        private readonly IRepository<TblSrdailyReportingTemp> _tblSrdailyReportingTemp;
        private readonly IRepository<TblSrdailyReportHsetemp> _tblSrdailyReportHsetemp;
        private readonly IRepository<TblSrdailyReportFileAttachmentsTemp> _tblSrdailyReportFileAttachmentsTemp;
        private readonly IRepository<TblSrdailyReportProgressMeasurementTemp> _tblSrdailyReportProgressMeasurementTemp;
        private readonly IRepository<TblSrdailyReportingIssuesTemp> _tblSrdailyReportingIssuesTemp;
        private readonly IRepository<TblSrdailyReportingDelaysTemp> _tblSrdailyReportingDelaysTemp;
        private readonly IRepository<TblAuthList> _auditRepository;
        private readonly IRepository<TblStaffBioData> _staffRepository;
        private readonly IRepository<TblWorkflowProcessDef> _tblWorkflowProcessDef;
        private readonly ISiteReportRepository _siteReportRepository;
        private readonly IUploadFileToBlob _uploadFile;
        private readonly IEmailSender _emailSender;
        private readonly IRepository<TblSrconstructionTechnicalQueriesTemp> _tblSrContructionTechnicalQueries;
        private readonly IRepository<TblSrconstructionTechnicalQueryAttachmentsTemp> _tblSrconstructionTechnicalQueryAttachmentsTemp;
        private readonly IRepository<TblSrconstructionTechnicalQueryRepliesTemp> _tblSrconstructionTechnicalQueryRepliesTemp;
        private readonly IRepository<TblCompanyInfo> _tblCompanyInfo;
        private readonly IRepository<TblCountry> _tblCountry;
        private readonly IRepository<TblState> _tblState;
        private readonly IRepository<TblCity> _tblCity;
        private readonly IRepository<TblProjects> _tblProject;
        private readonly IRepository<TblSupplierIdentification> _tblSupplierIdentification;
        private readonly IRepository<TblSrnonConformanceReportsTemp> _tblSrnonConformanceReportTemp;
        private readonly IRepository<TblSrncrattachmentsTemp> _tblSrncrattachmentsTemp;
        private readonly ApplicationDbContext _context;

        private readonly IRepository<TblSrdailyReportingGeneralSummaryTemp> _summaryRepository;
        private readonly IRepository<TblSrdailyReportHsetemp> _hseRepository;
        private readonly IRepository<TblSrdailyReportHseattachmentsTemp> _hseAttachmentRepository;
        private readonly IRepository<TblSrdailyReportingConstructionActivitiesTemp> _activityRepository;
        private readonly IRepository<TblSrdailyReportingProgressPicturesTemp> _progressPictureRepository;
        private readonly IRepository<TblSrdailyReportOtherSiteReportsTemp> _othersiteRepository;
        private readonly IMapper _mapper;



        /// <summary>
        /// The class construction with dependecny injections
        /// </summary>
        /// <param name="tblSrdailyReportingTemp"></param>
        /// <param name="tblSrdailyReportHsetemp"></param>
        /// <param name="tblSrdailyReportFileAttachmentsTemp"></param>
        /// <param name="tblSrdailyReportProgressMeasurementTemp"></param>
        /// <param name="tblSrdailyReportingIssuesTemp"></param>
        /// <param name="tblSrdailyReportingDelaysTemp"></param>
        /// <param name="tblWorkflowProcessDef"></param>
        /// <param name="codeGeneratorRepository"></param>
        /// <param name="auditRepository"></param>
        /// <param name="staffRepository"></param>
        /// <param name="uploadFile"></param>
        /// <param name="configuration"></param>
        /// <param name="siteReportRepository"></param>
        /// <param name="emailSender"></param>
        public SiteReportingController(
                IRepository<TblSrdailyReportingTemp> tblSrdailyReportingTemp,
                IRepository<TblSrdailyReportHsetemp> tblSrdailyReportHsetemp,
                IRepository<TblSrdailyReportFileAttachmentsTemp> tblSrdailyReportFileAttachmentsTemp,
                IRepository<TblSrdailyReportProgressMeasurementTemp> tblSrdailyReportProgressMeasurementTemp,
                IRepository<TblSrdailyReportingIssuesTemp> tblSrdailyReportingIssuesTemp,
                IRepository<TblSrdailyReportingDelaysTemp> tblSrdailyReportingDelaysTemp,
                IRepository<TblWorkflowProcessDef> tblWorkflowProcessDef,
                IRepository<TblAuthList> auditRepository,
                IRepository<TblStaffBioData> staffRepository,
                IUploadFileToBlob uploadFile,
                IConfiguration configuration,
                ISiteReportRepository siteReportRepository,
                IEmailSender emailSender,
                IRepository<TblSrconstructionTechnicalQueriesTemp> tblSrContructionTechnicalQueries,
                IRepository<TblSrconstructionTechnicalQueryAttachmentsTemp> tblSrconstructionTechnicalQueryAttachmentsTemp,
                IRepository<TblSrconstructionTechnicalQueryRepliesTemp> tblSrconstructionTechnicalQueryRepliesTemp,
                IRepository<TblCountry> tblCountry,
                IRepository<TblState> tblState,
                IRepository<TblCity> tblCity,
                IRepository<TblCompanyInfo> tblCompanyInfo,
                IRepository<TblProjects> tblProject,
                IRepository<TblSupplierIdentification> tblSupplierIdentification,
                IRepository<TblSrnonConformanceReportsTemp> tblSrnonConformanceReportTemp,
                IRepository<TblSrncrattachmentsTemp> tblSrncrattachmentsTemp,
                ApplicationDbContext context,

                IRepository<TblSrdailyReportingGeneralSummaryTemp> summaryRepository,
                IRepository<TblSrdailyReportHsetemp> hseRepository,
                IRepository<TblSrdailyReportHseattachmentsTemp> hseAttachmentRepository,
                IRepository<TblSrdailyReportingConstructionActivitiesTemp> activityRepository,
                IRepository<TblSrdailyReportingProgressPicturesTemp> progressPictureRepository,
                IRepository<TblSrdailyReportOtherSiteReportsTemp> othersiteRepository,
                IMapper mapper
            )
        {
            _tblSrdailyReportingTemp = tblSrdailyReportingTemp;
            _tblSrdailyReportHsetemp = tblSrdailyReportHsetemp;
            _tblSrdailyReportFileAttachmentsTemp = tblSrdailyReportFileAttachmentsTemp;
            _tblSrdailyReportProgressMeasurementTemp = tblSrdailyReportProgressMeasurementTemp;
            _tblSrdailyReportingIssuesTemp = tblSrdailyReportingIssuesTemp;
            _tblSrdailyReportingDelaysTemp = tblSrdailyReportingDelaysTemp;
            _tblWorkflowProcessDef = tblWorkflowProcessDef;
            _auditRepository = auditRepository;
            _staffRepository = staffRepository;
            _uploadFile = uploadFile;
            Configuration = configuration;
            _siteReportRepository = siteReportRepository;
            _emailSender = emailSender;
            _tblCountry = tblCountry;
            _tblCompanyInfo = tblCompanyInfo;
            _tblState = tblState;
            _tblCity = tblCity;
            _tblProject = tblProject;
            _mapper = mapper;
            _tblSrContructionTechnicalQueries = tblSrContructionTechnicalQueries;
            _tblSrconstructionTechnicalQueryAttachmentsTemp = tblSrconstructionTechnicalQueryAttachmentsTemp;
            _tblSrconstructionTechnicalQueryRepliesTemp = tblSrconstructionTechnicalQueryRepliesTemp;
            _tblSupplierIdentification = tblSupplierIdentification;
            _tblSrnonConformanceReportTemp = tblSrnonConformanceReportTemp;
            _tblSrncrattachmentsTemp = tblSrncrattachmentsTemp;
            _context = context;

            _summaryRepository = summaryRepository;
            _hseRepository = hseRepository;
            _hseAttachmentRepository = hseAttachmentRepository;
            _activityRepository = activityRepository;
            _progressPictureRepository = progressPictureRepository;
            _othersiteRepository = othersiteRepository;
        }

        public IConfiguration Configuration { get; }

        /// <summary>
        /// This method returns the user Id
        /// </summary>
        /// <returns name="string">string</returns>
        [NonAction]
        public string GetUserId()
        {
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var claim = claimsIdentity.Claims.Skip(1).FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier);


            var userId = claim.Value;
            return userId;
        }

        [HttpPost("generalsummary")]
        [ProducesResponseType(typeof(SucessResponse<object>), 200)]
        [ProducesResponseType(typeof(ErrorResponse<Dictionary<string, string[]>>), 400)]
        [ProducesResponseType(typeof(ErrorResponse<object>), 404)]
        public async Task<IActionResult> CreateGeneralSummary(SrdrGeneralSummaryDto summaryDto)
        {
            await using var transaction = await _context.Database.BeginTransactionAsync(); ;
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(new ErrorResponse<Dictionary<string, string[]>>
                    {
                        success = false,
                        message = "Your site reporting creation request failed",
                        errors = ModelState.Error().FilterError()
                    });
                }

                var company = await _tblCompanyInfo.FirstOrDefaultAsync(x => x.CompanyId == summaryDto.CompanyId);

                if (company == null)
                {
                    return NotFound(new ErrorResponse<object>
                    {
                        success = false,
                        message = $"Company with ID: {summaryDto.CompanyId} is not found",
                        errors = new { }
                    });
                }

                var project = await _tblProject.FirstOrDefaultAsync(x => x.ProjectId == summaryDto.ProjectId);

                if (project == null)
                {
                    return NotFound(new ErrorResponse<object>
                    {
                        success = false,
                        message = $"Project with ID: {summaryDto.ProjectId} is not found",
                        errors = new { }
                    });
                }

                var genSum = await _context.TblSrdailyReportingGeneralSummaryTemp.OrderByDescending(x => x.GenSumId).FirstOrDefaultAsync();
                var genSumNumber = genSum != null ? (genSum.GenSumId + 1).ToString("D4") : "0001";

                var raisedDate = $"{DateTime.Now.Day}{DateTime.Now.Month}{DateTime.Now.Year}";
                var projectName = project.ProjectName.ToUpper() ?? "NAME";
                var companyCode = company.CompanyCode ?? "DGS";
                var documentNumber = $"{companyCode.ToUpper()}/{projectName}/{"SDR"}/{raisedDate}{genSumNumber}";

                var userId = GetUserId();
                var tblStaff = await _staffRepository.FirstOrDefaultAsync(x => x.AspnetUserId == userId);

                var summary = _mapper.Map<TblSrdailyReportingGeneralSummaryTemp>(summaryDto);

                summary.CreatedBy = tblStaff.StaffId.ToString();
                summary.CreatedDate = DateTime.UtcNow;
                summary.DocumentNumber = documentNumber;

                var otherAttachment = new TblSrdailyReportingGenSumAttachmentsTemp
                {
                    OtherAttachment = summaryDto.OtherAttachment,
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = tblStaff.StaffId.ToString()
                };

                await _context.TblSrdailyReportingGenSumAttachmentsTemp.AddAsync(otherAttachment);
                await _context.SaveChangesAsync();

                summary.DrgsattId = otherAttachment.DrgsattId;

                await _summaryRepository.CreateAsync(summary);
                await _summaryRepository.SaveChangesAsync();

                var (checker, approver) = await _siteReportRepository.GetWorkflowApprovers(12);

                var newAudit = new TblAuthList
                {
                    Title = "General Summary",
                    Status = (int)EReportStatus.OPEN,
                    StaffId = tblStaff.StaffId,
                    BatchId = Guid.NewGuid().ToString(),
                    CreatedDate = DateTime.UtcNow,
                    WfdefId = (int)EWorflowDefinition.GENERALSUMMARY,
                    EventType = (int)EEventType.NEW,
                    RecId = summary.GenSumId,
                    CompanyId = summaryDto.CompanyId
                };

                await _auditRepository.CreateAsync(newAudit);
                await _auditRepository.SaveChangesAsync();

                await _emailSender.SendEmailAsync(checker, "General summary report created", "Log in to check the reports");

                await transaction.CommitAsync();

                return Ok(new SucessResponse<object>
                {
                    success = true,
                    message = "Site Report created successfully",
                    data = new { }
                });
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                return StatusCode(500, Response<string>.InternalError(ex.Message));
            }
        }

        /// <summary>
        /// Endpoint to create a Site daily HSE report
        /// </summary>
        /// <param name="hseReport"></param>
        /// <returns></returns>
        [HttpPost("hsereports")]
        [ProducesResponseType(typeof(SucessResponse<object>), 200)]
        [ProducesResponseType(typeof(ErrorResponse<Dictionary<string, string[]>>), 400)]
        [ProducesResponseType(typeof(ErrorResponse<object>), 404)]
        public async Task<IActionResult> CreateHSEReport(SrdrHseReportAttachmentDto hseReport)
        {
            await using var transaction = await _context.Database.BeginTransactionAsync();
            try
            {
                var userId = GetUserId();
                var tblStaff = await _staffRepository.FirstOrDefaultAsync(x => x.AspnetUserId == userId);
                                
                if (!ModelState.IsValid)
                {
                    return BadRequest(new ErrorResponse<Dictionary<string, string[]>>
                    {
                        success = false,
                        message = "HSE report creation request failed",
                        errors = ModelState.Error().FilterError()
                    });
                }

                var hseAttachment = _mapper.Map<TblSrdailyReportHseattachmentsTemp>(hseReport.SrdrHseReportAttachment);

                hseAttachment.CreatedDate = DateTime.UtcNow;
                hseAttachment.CreatedBy = tblStaff.StaffId.ToString();

                await _hseAttachmentRepository.CreateAsync(hseAttachment);
                await _hseAttachmentRepository.SaveChangesAsync();


                var raisedDate = $"{DateTime.Now.Day}{DateTime.Now.Month}{DateTime.Now.Year}";
                var srdrHseReport = new List<TblSrdailyReportHsetemp>();
                int? companyId = null;

                foreach (var item in hseReport.SrdrHSEReports)
                {
                    var company = await _tblCompanyInfo.FirstOrDefaultAsync(x => x.CompanyId == item.CompanyId);
                    companyId = company.CompanyId;

                    if (company == null)
                    {
                        return NotFound(new ErrorResponse<object>
                        {
                            success = false,
                            message = $"Company with ID: {item.CompanyId} is not found",
                            errors = new { }
                        });
                    }

                    var project = await _tblProject.FirstOrDefaultAsync(x => x.ProjectId == item.ProjectId);

                    if (project == null)
                    {
                        return NotFound(new ErrorResponse<object>
                        {
                            success = false,
                            message = $"Project with ID: {item.ProjectId} is not found",
                            errors = new { }
                        });
                    }

                    var hs = await _context.TblSrdailyReportHsetemp.OrderByDescending(x => x.Drhseid).FirstOrDefaultAsync();
                    var hsNumber = hs != null ? (hs.Drhseid + 1).ToString("D4") : "0001";

                    var projectName = project.ProjectName.ToUpper() ?? "NAME";
                    var companyCode = company.CompanyCode ?? "DGS";
                    var documentNumber = $"{companyCode.ToUpper()}/{projectName}/{"SDR"}/{raisedDate}{hsNumber}";

                    var hse = _mapper.Map<TblSrdailyReportHsetemp>(item);

                    hse.CreatedBy = tblStaff.StaffId.ToString();
                    hse.CreatedDate = DateTime.UtcNow;
                    hse.DocumentNumber = documentNumber;
                    hse.DrhseattId = hseAttachment.DrhseattId;

                    srdrHseReport.Add(hse);
                }                

                await _hseRepository.AddRangeAsync(srdrHseReport);
                await _hseRepository.SaveChangesAsync();

                var newAudit = new TblAuthList
                {
                    Title = "HSE Report",
                    Status = (int)EReportStatus.OPEN,
                    StaffId = tblStaff.StaffId,
                    BatchId = Guid.NewGuid().ToString(),
                    CreatedDate = DateTime.UtcNow,
                    WfdefId = (int)EWorflowDefinition.HSEREPORT,
                    EventType = (int)EEventType.NEW,
                    RecId = hseAttachment.DrhseattId,
                    CompanyId = companyId
                };

                await _auditRepository.CreateAsync(newAudit);
                await _auditRepository.SaveChangesAsync();

                var (checker, approver) = await _siteReportRepository.GetWorkflowApprovers(12);

                await _emailSender.SendEmailAsync(checker, "HSE attachment report created", "Log in to check the reports");

                await transaction.CommitAsync();

                return Ok(new SucessResponse<object>
                {
                    success = true,
                    message = "HSE report created successfully",
                    data = new { }
                });
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                return StatusCode(500, Response<string>.InternalError(ex.Message));
            }
        }

        /// <summary>
        /// Endpoint to create the Daily progress measurement score sheet
        /// </summary>
        /// <param name="meMasterDto"></param>
        /// <returns></returns>
        [HttpPost("dailyprogressmeasurement")]
        [ProducesResponseType(typeof(SucessResponse<object>), 200)]
        [ProducesResponseType(typeof(ErrorResponse<Dictionary<string, string[]>>), 400)]
        [ProducesResponseType(typeof(ErrorResponse<object>), 404)]
        public async Task<IActionResult> CreateDailyProgressMeasurement(SrDailyMeasurmentScoreDto meMasterDto)
        {
            await using var transaction = await _context.Database.BeginTransactionAsync();

            try
            {
                var userId = GetUserId();
                var tblStaff = await _staffRepository.FirstOrDefaultAsync(x => x.AspnetUserId == userId);

                if (!ModelState.IsValid)
                {
                    return BadRequest(new ErrorResponse<Dictionary<string, string[]>>
                    {
                        success = false,
                        message = "Report issues creation request failed",
                        errors = ModelState.Error().FilterError()
                    });
                }

                var company = await _tblCompanyInfo.FirstOrDefaultAsync(x => x.CompanyId == meMasterDto.SrdrProMeMaster.CompanyId);

                if (company == null)
                {
                    return NotFound(new ErrorResponse<object>
                    {
                        success = false,
                        message = $"Company with ID: {meMasterDto.SrdrProMeMaster.CompanyId} is not found",
                        errors = new { }
                    });
                }

                var project = await _tblProject.FirstOrDefaultAsync(x => x.ProjectId == meMasterDto.SrdrProMeMaster.ProjectId);

                if (project == null)
                {
                    return BadRequest(new ErrorResponse<object>
                    {
                        success = false,
                        message = $"Project with ID: {meMasterDto.SrdrProMeMaster.ProjectId} is not found",
                        errors = new { }
                    });
                }

                var errors = new Dictionary<string, string[]>();
                var delays = meMasterDto.SrdrDelays.ToArray();

                foreach (var staff in delays)
                {
                    var staffExist = await _staffRepository.ExistsAsync(x => x.StaffId == staff.Responsible.Value);

                    if (!staffExist)
                    {
                        errors.Add($"staffId[{Array.IndexOf(delays, staff)}]", new string[] { $"Staff of Id: {staff.Responsible} not found" });
                    }
                }

                if (errors.Count > 0)
                {
                    return NotFound(new ErrorResponse<Dictionary<string, string[]>>
                    {
                        success = false,
                        message = $"Some staffs are not found",
                        errors = errors
                    });
                }

                var projectName = project.ProjectName.ToUpper() ?? "NAME";
                var companyCode = company.CompanyCode ?? "DGS";
                var raisedDate = $"{DateTime.Now.Day}{DateTime.Now.Month}{DateTime.Now.Year}";

                var master = _mapper.Map<TblSrdailyReportProgressMeasurementMasterTemp>(meMasterDto.SrdrProMeMaster);

                master.CreatedBy = tblStaff.StaffId.ToString();
                master.CreatedDate = DateTime.UtcNow;

                await _context.TblSrdailyReportProgressMeasurementMasterTemp.AddAsync(master);
                await _context.SaveChangesAsync();

                var documentNumber = $"{companyCode.ToUpper()}/{projectName}/{"SDR"}/{master.ProMeMasterId + 1}";

                master.DocumentNumber = documentNumber;

                _context.TblSrdailyReportProgressMeasurementMasterTemp.Update(master);
                await _context.SaveChangesAsync();


                var pgMeasurementDetails = _mapper.Map<IEnumerable<TblSrdailyReportProgressMeasurementDetailsTemp>>(meMasterDto.SrdrProgressMeasurements);
                var srdrDelays = _mapper.Map<IEnumerable<TblSrdailyReportingDelaysTemp>>(meMasterDto.SrdrDelays);
                var srdrIssues = _mapper.Map<IEnumerable<TblSrdailyReportingIssuesTemp>>(meMasterDto.SrdrIssues);

                foreach (var pgMeasurementDetail in pgMeasurementDetails)
                {
                    pgMeasurementDetail.CreatedBy = tblStaff.StaffId.ToString();
                    pgMeasurementDetail.CreatedDate = DateTime.UtcNow;
                    pgMeasurementDetail.ProMeMasterId = master.ProMeMasterId;
                }

                foreach (var srdrDelay in srdrDelays)
                {
                    srdrDelay.CreatedBy = tblStaff.StaffId.ToString();
                    srdrDelay.CreatedDate = DateTime.UtcNow;
                    srdrDelay.ProMeMasterId = master.ProMeMasterId;
                }

                foreach (var srdrIssue in srdrIssues)
                {
                    srdrIssue.CreatedBy = tblStaff.StaffId.ToString();
                    srdrIssue.CreatedDate = DateTime.UtcNow;
                    srdrIssue.ProMeMasterId = master.ProMeMasterId;
                }

                await _context.TblSrdailyReportProgressMeasurementDetailsTemp.AddRangeAsync(pgMeasurementDetails);
                await _context.TblSrdailyReportingDelaysTemp.AddRangeAsync(srdrDelays);
                await _context.TblSrdailyReportingIssuesTemp.AddRangeAsync(srdrIssues);
                await _context.SaveChangesAsync();

                var newAudit = new TblAuthList
                {
                    Title = "Daily Progress Measurement",
                    Status = (int)EReportStatus.OPEN,
                    StaffId = tblStaff.StaffId,
                    BatchId = Guid.NewGuid().ToString(),
                    CreatedDate = DateTime.UtcNow,
                    WfdefId = (int)EWorflowDefinition.DAILYPGMEASUREMENT,
                    EventType = (int)EEventType.NEW,
                    RecId = master.ProMeMasterId,
                    CompanyId = company.CompanyId
                };

                await _auditRepository.CreateAsync(newAudit);

                await _context.SaveChangesAsync();

                var (checker, approver) = await _siteReportRepository.GetWorkflowApprovers(12);

                await _emailSender.SendEmailAsync(checker, "Daily progress measurement created", "Log in to check the reports");

                await transaction.CommitAsync();

                return Ok(new SucessResponse<object>
                {
                    success = true,
                    message = "Daily reporting issues created successfully",
                    data = new { }
                });
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                return StatusCode(500, Response<string>.InternalError(ex.Message));
            }
        }

        /// <summary>
        /// Endpoint to create a Site daily construction activitiy report
        /// </summary>
        /// <param name="conActivity"></param>
        /// <returns></returns>
        [HttpPost("constructionActivities")]
        [ProducesResponseType(typeof(SucessResponse<object>), 200)]
        [ProducesResponseType(typeof(ErrorResponse<Dictionary<string, string[]>>), 400)]
        [ProducesResponseType(typeof(ErrorResponse<object>), 404)]
        public async Task<IActionResult> CreateConstructionActivities(SrdrConstructionActivitiesDto conActivity)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(new ErrorResponse<Dictionary<string, string[]>>
                    {
                        success = false,
                        message = "HSE report creation request failed",
                        errors = ModelState.Error().FilterError()
                    });
                }

                var company = await _tblCompanyInfo.FirstOrDefaultAsync(x => x.CompanyId == conActivity.CompanyId);

                if (company == null)
                {
                    return NotFound(new ErrorResponse<object>
                    {
                        success = false,
                        message = $"Company with ID: {conActivity.CompanyId} is not found",
                        errors = new { }
                    });
                }

                var project = await _tblProject.FirstOrDefaultAsync(x => x.ProjectId == conActivity.ProjectId);

                if (project == null)
                {
                    return NotFound(new ErrorResponse<object>
                    {
                        success = false,
                        message = $"Project with ID: {conActivity.ProjectId} is not found",
                        errors = new { }
                    });
                }

                var con = await _context.TblSrdailyReportingConstructionActivitiesTemp.OrderByDescending(x => x.DrconActId).FirstOrDefaultAsync();
                var conNumber = con != null ? (con.DrconActId + 1).ToString("D4") : "0001";

                var raisedDate = $"{DateTime.Now.Day}{DateTime.Now.Month}{DateTime.Now.Year}";
                var projectName = project.ProjectName.ToUpper() ?? "NAME";
                var companyCode = company.CompanyCode ?? "DGS";
                var documentNumber = $"{companyCode.ToUpper()}/{projectName}/{"SDR"}/{raisedDate}{conNumber}";

                var userId = GetUserId();
                var tblStaff = await _staffRepository.FirstOrDefaultAsync(x => x.AspnetUserId == userId);

                var activities = _mapper.Map<TblSrdailyReportingConstructionActivitiesTemp>(conActivity);

                activities.DocumentNumber = documentNumber;
                activities.CreatedBy = tblStaff.StaffId.ToString();
                activities.CreatedDate = DateTime.UtcNow;

                await _activityRepository.CreateAsync(activities);
                await _activityRepository.SaveChangesAsync();

                var newAudit = new TblAuthList
                {
                    Title = "Construction Activities",
                    Status = (int)EReportStatus.OPEN,
                    StaffId = tblStaff.StaffId,
                    BatchId = Guid.NewGuid().ToString(),
                    CreatedDate = DateTime.UtcNow,
                    WfdefId = (int)EWorflowDefinition.CONSTRUCTIONACTIVITY,
                    EventType = (int)EEventType.NEW,
                    RecId = activities.DrconActId, 
                    CompanyId = company.CompanyId
                };

                await _auditRepository.CreateAsync(newAudit);
                await _auditRepository.SaveChangesAsync();

                var (checker, approver) = await _siteReportRepository.GetWorkflowApprovers(12);

                await _emailSender.SendEmailAsync(checker, "Construction activities report created", "Log in to check the reports");

                return Ok(new SucessResponse<object>
                {
                    success = true,
                    message = "Construction activity report created successfully",
                    data = new { }
                });
            }
            catch (Exception ex)
            {
                 return StatusCode(500, Response<string>.InternalError(ex.Message));
            }
        }


        /// <summary>
        /// Endpoint to create Site daily progress pictures report
        /// </summary>
        /// <param name="picturesDto"></param>
        /// <returns></returns>
        [HttpPost("progresspictures")]
        [ProducesResponseType(typeof(SucessResponse<object>), 200)]
        [ProducesResponseType(typeof(ErrorResponse<Dictionary<string, string[]>>), 400)]
        [ProducesResponseType(typeof(ErrorResponse<object>), 404)]
        public async Task<IActionResult> CreateProgressPictures(SrdrProgresssPicturesDto picturesDto)
        {
            await using var transaction = await _context.Database.BeginTransactionAsync();
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(new ErrorResponse<Dictionary<string, string[]>>
                    {
                        success = false,
                        message = "HSE report creation request failed",
                        errors = ModelState.Error().FilterError()
                    });
                }

                var company = await _tblCompanyInfo.FirstOrDefaultAsync(x => x.CompanyId == picturesDto.CompanyId);

                if (company == null)
                {
                    return NotFound(new ErrorResponse<object>
                    {
                        success = false,
                        message = $"Company with ID: {picturesDto.CompanyId} is not found",
                        errors = new { }
                    });
                }

                var project = await _tblProject.FirstOrDefaultAsync(x => x.ProjectId == picturesDto.ProjectId);

                if (project == null)
                {
                    return NotFound(new ErrorResponse<object>
                    {
                        success = false,
                        message = $"Project with ID: {picturesDto.ProjectId} is not found",
                        errors = new { }
                    });
                }

                var pp = await _context.TblSrdailyReportingProgressPicturesTemp.OrderByDescending(x => x.Ppid).FirstOrDefaultAsync();
                var ppNumber = pp != null ? (pp.Ppid + 1).ToString("D4") : "0001";

                var raisedDate = $"{DateTime.Now.Day}{DateTime.Now.Month}{DateTime.Now.Year}";
                var projectName = project.ProjectName.ToUpper() ?? "NAME";
                var companyCode = company.CompanyCode ?? "DGS";
                var documentNumber = $"{companyCode.ToUpper()}/{projectName}/{"SDR"}/{raisedDate}{ppNumber}";

                var userId = GetUserId();
                var tblStaff = await _staffRepository.FirstOrDefaultAsync(x => x.AspnetUserId == userId);

                var pictures = _mapper.Map<TblSrdailyReportingProgressPicturesTemp>(picturesDto);

                pictures.CreatedBy = tblStaff.StaffId.ToString();
                pictures.CreatedDate = DateTime.UtcNow;
                pictures.DocumentNumber = documentNumber;

                await _progressPictureRepository.CreateAsync(pictures);
                await _progressPictureRepository.SaveChangesAsync();

                var prgPictures = new List<TblSrdrprogressPicturesAttachmentsTemp>();

                if (picturesDto.ProgressPictures.Count > 0)
                {
                    foreach (var progressPicture in picturesDto.ProgressPictures)
                    {
                        prgPictures.Add(new TblSrdrprogressPicturesAttachmentsTemp
                        {
                            Ppid = pictures.Ppid,
                            Description = progressPicture.Description,
                            ProgressPictures = progressPicture.ProgressPictures,
                            CreatedBy = tblStaff.StaffId.ToString(),
                            CreatedDate = DateTime.UtcNow
                        });
                    }

                    await _context.TblSrdrprogressPicturesAttachmentsTemp.AddRangeAsync(prgPictures);
                    await _context.SaveChangesAsync();
                }                

                var newAudit = new TblAuthList
                {
                    Title = "Progress Pictures",
                    Status = (int)EReportStatus.OPEN,
                    StaffId = tblStaff.StaffId,
                    BatchId = Guid.NewGuid().ToString(),
                    CreatedDate = DateTime.UtcNow,
                    WfdefId = (int)EWorflowDefinition.PROGRESSPICTURES,
                    EventType = (int)EEventType.NEW,
                    RecId = pictures.Ppid,
                    CompanyId = company.CompanyId
                };

                await _auditRepository.CreateAsync(newAudit);
                await _auditRepository.SaveChangesAsync();

                var (checker, approver) = await _siteReportRepository.GetWorkflowApprovers(12);

                await _emailSender.SendEmailAsync(checker, "Progress Pictures report created", "Log in to check the reports");

                await transaction.CommitAsync();

                return Ok(new SucessResponse<object>
                {
                    success = true,
                    message = "Progress picture report created successfully",
                    data = new { }
                });
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                return StatusCode(500, Response<string>.InternalError(ex.Message));
            }
        }

        /// <summary>
        /// Endpoint to create a site daily other sites report
        /// </summary>
        /// <param name="srdrOtherSiteDto"></param>
        /// <returns></returns>
        [HttpPost("othersites")]
        [ProducesResponseType(typeof(SucessResponse<object>), 200)]
        [ProducesResponseType(typeof(ErrorResponse<Dictionary<string, string[]>>), 400)]
        [ProducesResponseType(typeof(ErrorResponse<object>), 404)]
        public async Task<IActionResult> CreateOtherSiteReport(SrdrOtherSiteReportDto srdrOtherSiteDto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(new ErrorResponse<Dictionary<string, string[]>>
                    {
                        success = false,
                        message = "HSE report creation request failed",
                        errors = ModelState.Error().FilterError()
                    });
                }

                var company = await _tblCompanyInfo.FirstOrDefaultAsync(x => x.CompanyId == srdrOtherSiteDto.CompanyId);

                if (company == null)
                {
                    return NotFound(new ErrorResponse<object>
                    {
                        success = false,
                        message = $"Company with ID: {srdrOtherSiteDto.CompanyId} is not found",
                        errors = new { }
                    });
                }

                var project = await _tblProject.FirstOrDefaultAsync(x => x.ProjectId == srdrOtherSiteDto.ProjectId);

                if (project == null)
                {
                    return NotFound(new ErrorResponse<object>
                    {
                        success = false,
                        message = $"Project with ID: {srdrOtherSiteDto.ProjectId} is not found",
                        errors = new { }
                    });
                }

                var other = await _context.TblSrdailyReportOtherSiteReportsTemp.OrderByDescending(x => x.OsrepId).FirstOrDefaultAsync();
                var otherNumber = other != null ? (other.OsrepId + 1).ToString("D4") : "0001";

                var raisedDate = $"{DateTime.Now.Day}{DateTime.Now.Month}{DateTime.Now.Year}";
                var projectName = project.ProjectName.ToUpper() ?? "NAME";
                var companyCode = company.CompanyCode ?? "DGS";
                var documentNumber = $"{companyCode.ToUpper()}/{projectName}/{"SDR"}/{raisedDate}{otherNumber}";

                var userId = GetUserId();
                var tblStaff = await _staffRepository.FirstOrDefaultAsync(x => x.AspnetUserId == userId);

                var srdrOtherSite = _mapper.Map<TblSrdailyReportOtherSiteReportsTemp>(srdrOtherSiteDto);

                srdrOtherSite.DocumentNumber = documentNumber;
                srdrOtherSite.CreatedBy = tblStaff.StaffId.ToString();
                srdrOtherSite.CreatedDate = DateTime.UtcNow;

                await _othersiteRepository.CreateAsync(srdrOtherSite);
                await _othersiteRepository.SaveChangesAsync();

                var newAudit = new TblAuthList
                {
                    Title = "Other site Report",
                    Status = (int)EReportStatus.OPEN,
                    StaffId = tblStaff.StaffId,
                    BatchId = Guid.NewGuid().ToString(),
                    CreatedDate = DateTime.UtcNow,
                    WfdefId = (int)EWorflowDefinition.OTHERSITE,
                    EventType = (int)EEventType.NEW,
                    RecId = srdrOtherSite.OsrepId,
                    CompanyId = company.CompanyId,
                };

                await _auditRepository.CreateAsync(newAudit);
                await _auditRepository.SaveChangesAsync();

                var (checker, approver) = await _siteReportRepository.GetWorkflowApprovers(12);

                await _emailSender.SendEmailAsync(checker, "Other Site Report tendered", "Log in to check the reports");

                return Ok(new SucessResponse<object>
                {
                    success = true,
                    message = "Other site report created successfully",
                    data = new { }
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500, Response<string>.InternalError(ex.Message));
            }
        }

        /// <summary>
        /// This method is used to create a technical query
        /// </summary>
        /// <param name="technicalQueriesDto"></param>
        /// <returns></returns>
        [HttpPost("[action]")]
        public async Task<IActionResult> CreateTechnicalQueries(TechnicalQueriesFormDto technicalQueriesDto)
        {
            await using var transaction = await _context.Database.BeginTransactionAsync();

            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(new ErrorResponse<Dictionary<string, string[]>>
                    {
                        success = false,
                        message = "Your construction technical query request failed",
                        errors = ModelState.Error().FilterError()
                    });
                }

                var userId = GetUserId();
                var tblStaff = await _staffRepository.FirstOrDefaultAsync(x => x.AspnetUserId == userId);

                var country = await _tblCountry.ExistsAsync(x => x.CountryId == technicalQueriesDto.CountryId);
                var state = await _tblState.ExistsAsync(x => x.StateId == technicalQueriesDto.StateId);
                var city = await _tblCity.ExistsAsync(x => x.CityId == technicalQueriesDto.CityId);
                var project = await _tblProject.FirstOrDefaultAsync(x => x.ProjectId == technicalQueriesDto.ProjectId);
                var attendee = await _staffRepository.FirstOrDefaultAsync(x => x.StaffId == technicalQueriesDto.AttendeeId);


                var company = await _tblCompanyInfo.FirstOrDefaultAsync(x => x.CompanyId == tblStaff.CompanyId);
                var raisedDate = $"{DateTime.Now.Day}{DateTime.Now.Month}{DateTime.Now.Year}";

                if (project == null)
                {
                    return NotFound(new ErrorResponse<object>
                    {
                        success = false,
                        message = $"Project with ID: {technicalQueriesDto.ProjectId} is not found",
                        errors = new { }
                    });
                }
                var projectName = project.ProjectName.ToUpper() ?? "NAME";


                if (!Enum.IsDefined(typeof(EPriority), technicalQueriesDto.Priority))
                {
                    return BadRequest(new ErrorResponse<Dictionary<string, string[]>>
                    {
                        success = false,
                        message = "Your construction technical query request failed",
                        errors = new Dictionary<string, string[]>
                    {
                        { "priority", new string[] {"Priority should be 0, 1 or 2"} }
                    }
                    });
                }

                if (tblStaff == null)
                {
                    return NotFound(new ErrorResponse<object>
                    {
                        success = false,
                        message = $"Staff with ID: {userId} is not found",
                        errors = new { }
                    });
                }

                if (!country)
                {
                    return NotFound(new ErrorResponse<object>
                    {
                        success = false,
                        message = $"Country with ID: {technicalQueriesDto.CountryId} is not found",
                        errors = new { }
                    });
                }

                if (!state)
                {
                    return NotFound(new ErrorResponse<object>
                    {
                        success = false,
                        message = $"State with ID: {technicalQueriesDto.StateId} is not found",
                        errors = new { }
                    });
                }

                if (!city)
                {
                    return NotFound(new ErrorResponse<object>
                    {
                        success = false,
                        message = $"City with ID: {technicalQueriesDto.CityId} is not found",
                        errors = new { }
                    });
                }

                if (attendee == null)
                {
                    return NotFound(new ErrorResponse<object>
                    {
                        success = false,
                        message = $"Attendee with ID: {technicalQueriesDto.AttendeeId} is not found",
                        errors = new { }
                    });
                }

                if (project == null)
                {
                    return NotFound(new ErrorResponse<object>
                    {
                        success = false,
                        message = $"Project with ID: {technicalQueriesDto.ProjectId} is not found",
                        errors = new { }
                    });
                }

                if (company == null)
                {
                    return NotFound(new ErrorResponse<object>
                    {
                        success = false,
                        message = $"Company with ID: {tblStaff.CompanyId} is not found",
                        errors = new { }
                    });
                }

                var technicalQueries = _mapper.Map<TblSrconstructionTechnicalQueriesTemp>(technicalQueriesDto);

                var companyCode = company.CompanyCode ?? "DGS";
                var referenceNumber = $"{companyCode.ToUpper()}/{projectName}/{"CTQ"}/{raisedDate}/{technicalQueries.Ctqid + 1}";

                technicalQueries.StaffId = tblStaff.StaffId;
                technicalQueries.CreatedBy = tblStaff.StaffId.ToString();
                technicalQueries.CreatedDate = DateTime.Now;
                technicalQueries.Status = (int)EDefaultStatus.Open;
                technicalQueries.Ctqnumber = referenceNumber;

                await _tblSrContructionTechnicalQueries.CreateAsync(technicalQueries);
                await _tblSrContructionTechnicalQueries.SaveChangesAsync();

                var technicalQueryReplies = new TblSrconstructionTechnicalQueryRepliesTemp
                {
                    Ctqid = technicalQueries.Ctqid,
                    CreatedBy = tblStaff.StaffId.ToString(),
                    CreatedDate = DateTime.Now,
                    InitiatorAcceptance = (int)EDefaultStatus.Open
                };

                await _tblSrconstructionTechnicalQueryRepliesTemp.CreateAsync(technicalQueryReplies);
                await _tblSrconstructionTechnicalQueryRepliesTemp.SaveChangesAsync();

                var ctqAttachment = new TblSrconstructionTechnicalQueryAttachmentsTemp
                {
                    Ctqid = technicalQueries.Ctqid,
                    CreatedBy = tblStaff.StaffId.ToString(),
                    CreatedDate = DateTime.UtcNow,
                    DrawingFile = technicalQueriesDto.DrawingFile,
                    ReferenceNumber = referenceNumber
                };

                await _tblSrconstructionTechnicalQueryAttachmentsTemp.CreateAsync(ctqAttachment);
                await _tblSrconstructionTechnicalQueryAttachmentsTemp.SaveChangesAsync();

                await transaction.CommitAsync();

                return Ok(new SucessResponse<object>
                {
                    success = true,
                    message = "Construction Technical query created successfully",
                    data = new { }
                });
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                return StatusCode(500, Response<string>.InternalError(ex.Message));
            }
        }

        /// <summary>
        /// This method is used to reply the construction technical
        /// queries created by the initiator
        /// </summary>
        /// <param name="attentionReply"></param>
        /// <param name="ctqId"></param>
        /// <returns></returns>
        [HttpPost("[action]")]
        public async Task<IActionResult> AttentionReply(AttentionReplyFormDto attentionReply, int ctqId)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(new ErrorResponse<Dictionary<string, string[]>>
                    {
                        success = false,
                        message = "Your construction technical query request failed",
                        errors = ModelState.Error().FilterError()
                    });
                }

                var userId = GetUserId();
                var tblStaff = await _staffRepository.FirstOrDefaultAsync(x => x.AspnetUserId == userId);

                if (tblStaff == null)
                {
                    return NotFound(new ErrorResponse<object>
                    {
                        success = false,
                        message = $"Attention with ID: {userId} is not found",
                        errors = new { }
                    });
                }

                if (attentionReply.AttentionDate.Day < DateTime.Now.Day)
                {
                    return BadRequest(new ErrorResponse<Dictionary<string, string[]>>
                    {
                        success = false,
                        message = "Your construction technical query request failed",
                        errors = new Dictionary<string, string[]>
                    {
                        { "attentionDate", new string[] {"Attention date should not be less than today"} }
                    }
                    });
                }

                var ctqEntity = await _tblSrContructionTechnicalQueries.FirstOrDefaultAsync(x => x.Ctqid == ctqId);

                if (ctqEntity == null)
                {
                    return NotFound(new ErrorResponse<object>
                    {
                        success = false,
                        message = $"Construction technical query with ID: {ctqId} is not found",
                        errors = new { }
                    });
                }

                if (ctqEntity.Attention != tblStaff.StaffId)
                {
                    return NotFound(new ErrorResponse<object>
                    {
                        success = false,
                        message = $"This staff with ID {ctqId} is not assigned to attend to this report",
                        errors = new { }
                    });
                }

                var replyEntity = await _siteReportRepository.GetCTQByIdDescOrder(ctqId);

                if (replyEntity == null)
                {
                    return NotFound(new ErrorResponse<object>
                    {
                        success = false,
                        message = $"CTQ reply with CtqId of {ctqId} is not found",
                        errors = new { }
                    });
                }

                replyEntity.AttentionReply = attentionReply.AttentionReply;
                replyEntity.AttentionReplyDate = attentionReply.AttentionDate;
                replyEntity.ModifiedBy = tblStaff.StaffId.ToString();
                replyEntity.ModifiedDate = DateTime.UtcNow;

                _tblSrconstructionTechnicalQueryRepliesTemp.Update(replyEntity);
                await _tblSrconstructionTechnicalQueryRepliesTemp.SaveChangesAsync();

                var initiator = await _staffRepository.FirstOrDefaultAsync(x => x.StaffId == ctqEntity.StaffId);

                await _emailSender.SendEmailAsync(initiator.OfficeEmailAddress, "Attendee Reply", "An Attendee replied one of your queries");

                return Ok(new SucessResponse<object>
                {
                    success = true,
                    message = "Construction technical query reply updated successfully",
                    data = new { }
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500, Response<string>.InternalError(ex.Message));
            }
        }

        /// <summary>
        /// This method is used to reply construction technical
        /// queries by the initiator
        /// </summary>
        /// <param name="initiatorReply"></param>
        /// <param name="ctqId"></param>
        /// <returns></returns>
        [HttpPost("[action]")]
        public async Task<IActionResult> InitiatorReply(InitiatorReplyFormDto initiatorReply, int ctqId)
        {
            using var transaction = await _context.Database.BeginTransactionAsync();
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(new ErrorResponse<Dictionary<string, string[]>>
                    {
                        success = false,
                        message = "Your construction technical query request failed",
                        errors = ModelState.Error().FilterError()
                    });
                }

                if (!Enum.IsDefined(typeof(EInitiatorAcceptance), initiatorReply.InitiatorAcceptance))
                {
                    return BadRequest(new ErrorResponse<Dictionary<string, string[]>>
                    {
                        success = false,
                        message = "Your construction technical query request failed",
                        errors = new Dictionary<string, string[]>
                    {
                        { "initiatorAcceptance", new string[] {"Initiator's acceptance should be 1, 2"} }
                    }
                    });
                }

                var userId = GetUserId();
                var tblStaff = await _staffRepository.FirstOrDefaultAsync(x => x.AspnetUserId == userId);
                var company = await _tblCompanyInfo.FirstOrDefaultAsync(x => x.CompanyId == tblStaff.CompanyId);

                if (tblStaff == null)
                {
                    return NotFound(new ErrorResponse<object>
                    {
                        success = false,
                        message = $"Initiator with ID: {userId} is not found",
                        errors = new { }
                    });
                }

                if (initiatorReply.InitiatorReplyDate.Day < DateTime.Now.Day)
                {
                    return BadRequest(new ErrorResponse<Dictionary<string, string[]>>
                    {
                        success = false,
                        message = "Your construction technical query request failed",
                        errors = new Dictionary<string, string[]>
                    {
                        { "initiatorReplyDate", new string[] {"Initaitor reply date should not be less than today"} }
                    }
                    });
                }

                var ctqEntity = await _tblSrContructionTechnicalQueries.FirstOrDefaultAsync(x => x.Ctqid == ctqId);

                if (ctqEntity == null)
                {
                    return NotFound(new ErrorResponse<object>
                    {
                        success = false,
                        message = $"Construction technical query with ID: {ctqEntity.StaffId} is not found",
                        errors = new { }
                    });
                }

                if (ctqEntity.StaffId != tblStaff.StaffId)
                {
                    return NotFound(new ErrorResponse<object>
                    {
                        success = false,
                        message = $"This staff with ID {ctqId} is not the initiator of this report",
                        errors = new { }
                    });
                }

                var replyEntity = await _tblSrconstructionTechnicalQueryRepliesTemp.FirstOrDefaultAsync(x => x.Ctqid == ctqId);
                var ctqAttchment = await _tblSrconstructionTechnicalQueryAttachmentsTemp.FirstOrDefaultAsync(x => x.Ctqid == ctqId);
                var authEntity = await _context.TblAuthList.FirstOrDefaultAsync(x => x.RecId.Value == ctqId);

                if (replyEntity == null)
                {
                    return NotFound(new ErrorResponse<object>
                    {
                        success = false,
                        message = $"CTQ reply with CtqId of {ctqId} is not found",
                        errors = new { }
                    });
                }

                ctqEntity.Status = initiatorReply.InitiatorAcceptance;
                _tblSrContructionTechnicalQueries.Update(ctqEntity);
                await _tblSrContructionTechnicalQueries.SaveChangesAsync();

                var ctqReply = new TblSrconstructionTechnicalQueryRepliesTemp
                {
                    Ctqid = ctqId,
                    InitiatorAcceptance = initiatorReply.InitiatorAcceptance,
                    InitiatorReply = initiatorReply.InitiatorReply,
                    InitiatorReplyDate = initiatorReply.InitiatorReplyDate,
                    CreatedBy = tblStaff.StaffId.ToString(),
                    CreatedDate = DateTime.UtcNow,
                };

                await _tblSrconstructionTechnicalQueryRepliesTemp.CreateAsync(ctqReply);
                await _tblSrconstructionTechnicalQueryRepliesTemp.SaveChangesAsync();

                var attention = await _staffRepository.FirstOrDefaultAsync(x => x.StaffId == ctqEntity.Attention);

                await _emailSender.SendEmailAsync(attention.OfficeEmailAddress, "Initiator Reply", "An Initiator has responded to one of your queries");

                if ((int)EInitiatorAcceptance.Approve == initiatorReply.InitiatorAcceptance)
                {
                    var (checker, approver) = await _siteReportRepository.GetWorkflowApprovers(11);

                    await _emailSender.SendEmailAsync(checker, "Construction technical report", "Log in to check the reports");
                    await _emailSender.SendEmailAsync(approver, "Construction technical report", "Log in to check the reports");

                    await _emailSender.SendEmailAsync(attention.OfficeEmailAddress, "Initiator Reply", "Your construction technical query has been approved");

                    var newAudit = new TblAuthList
                    {
                        Title = "Construction Technical Report",
                        Status = (int)EReportStatus.OPEN,
                        StaffId = tblStaff.StaffId,
                        BatchId = Guid.NewGuid().ToString(),
                        CreatedDate = DateTime.UtcNow,
                        WfdefId = (int)EWorflowDefinition.CONSTRUCTIONTECHNICALQUERY,
                        EventType = (int)EEventType.NEW,
                        RecId = ctqEntity.Ctqid,
                        CompanyId = company.CompanyId
                    };

                    await _auditRepository.CreateAsync(newAudit);
                    await _auditRepository.SaveChangesAsync();

                    await transaction.CommitAsync();
                }

                return Ok(new SucessResponse<object>
                {
                    success = true,
                    message = "Construction technical query reply updated successfully",
                    data = new { }
                });
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                return StatusCode(500, Response<string>.InternalError(ex.Message));
            }
        }

        /// <summary>
        /// Endpoint to create a Technical NonConformance report
        /// </summary>
        /// <param name="reportFormtDto"></param>
        /// <returns></returns>
        [HttpPost("[action]")]
        public async Task<IActionResult> NonTechnicalQuery(NonConformanceReporFormtDto reportFormtDto)
        {
            await using var transaction = await _context.Database.BeginTransactionAsync();
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(new ErrorResponse<Dictionary<string, string[]>>
                    {
                        success = false,
                        message = "Your Non conformance report request failed",
                        errors = ModelState.Error().FilterError()
                    });
                }

                var userId = GetUserId();
                var tblStaff = await _staffRepository.FirstOrDefaultAsync(x => x.AspnetUserId == userId);

                var country = await _tblCountry.ExistsAsync(x => x.CountryId == reportFormtDto.CountryId);
                var state = await _tblState.ExistsAsync(x => x.StateId == reportFormtDto.StateId);
                var city = await _tblCity.ExistsAsync(x => x.CityId == reportFormtDto.CityId);
                var project = await _tblProject.FirstOrDefaultAsync(x => x.ProjectId == reportFormtDto.ProjectId);
                var supplier = await _tblSupplierIdentification.ExistsAsync(x => x.SupplierId == reportFormtDto.SupplierId);

                var company = await _tblCompanyInfo.FirstOrDefaultAsync(x => x.CompanyId == tblStaff.CompanyId);
                var raisedDate = $"{DateTime.Now.Day}{DateTime.Now.Month}{DateTime.Now.Year}";

                if (project == null)
                {
                    return NotFound(new ErrorResponse<object>
                    {
                        success = false,
                        message = $"Project with ID: {reportFormtDto.ProjectId} is not found",
                        errors = new { }
                    });
                }
                var projectName = project.ProjectName.ToUpper() ?? "NAME";

                if (tblStaff == null)
                {
                    return NotFound(new ErrorResponse<object>
                    {
                        success = false,
                        message = $"Staff with ID: {userId} is not found",
                        errors = new { }
                    });
                }

                if (!country)
                {
                    return NotFound(new ErrorResponse<object>
                    {
                        success = false,
                        message = $"Country with ID: {reportFormtDto.CountryId} is not found",
                        errors = new { }
                    });
                }

                if (!state)
                {
                    return NotFound(new ErrorResponse<object>
                    {
                        success = false,
                        message = $"State with ID: {reportFormtDto.StateId} is not found",
                        errors = new { }
                    });
                }

                if (!city)
                {
                    return NotFound(new ErrorResponse<object>
                    {
                        success = false,
                        message = $"City with ID: {reportFormtDto.CityId} is not found",
                        errors = new { }
                    });
                }

                if (project == null)
                {
                    return NotFound(new ErrorResponse<object>
                    {
                        success = false,
                        message = $"Project with ID: {reportFormtDto.ProjectId} is not found",
                        errors = new { }
                    });
                }

                if (company == null)
                {
                    return NotFound(new ErrorResponse<object>
                    {
                        success = false,
                        message = $"Company with ID: {tblStaff.CompanyId} is not found",
                        errors = new { }
                    });
                }

                if (!supplier)
                {
                    return NotFound(new ErrorResponse<object>
                    {
                        success = false,
                        message = $"Supplier with ID: {reportFormtDto.SupplierId} is not found",
                        errors = new { }
                    });
                }

                var technicalQueries = _mapper.Map<TblSrnonConformanceReportsTemp>(reportFormtDto);

                technicalQueries.CreatedBy = tblStaff.StaffId.ToString();
                technicalQueries.IssuedBy = tblStaff.StaffId.ToString();
                technicalQueries.IssuedDate = DateTime.UtcNow;
                technicalQueries.CreatedDate = DateTime.Now;

                await _tblSrnonConformanceReportTemp.CreateAsync(technicalQueries);
                await _tblSrnonConformanceReportTemp.SaveChangesAsync();

                var companyCode = company.CompanyCode ?? "DGS";
                var refNumber = $"{companyCode.ToUpper()}/{projectName}/{"NCR"}/{raisedDate}/{technicalQueries.Ncrid + 1}";

                technicalQueries.TagNumber = $"{companyCode.ToUpper()}/{projectName}/{"NCR"}/{"TAG"}/{technicalQueries.Ncrid + 1}";
                technicalQueries.ReportNumber = $"{companyCode.ToUpper()}/{projectName}/{"NCR"}/{"RTN"}/{technicalQueries.Ncrid + 1}";
                technicalQueries.DocumentNumber = $"{companyCode.ToUpper()}/{projectName}/{"NCR"}/{"DOC"}/{technicalQueries.Ncrid + 1}";
                technicalQueries.AreaModuleNumber = $"{companyCode.ToUpper()}/{projectName}/{"NCR"}/{"ARN"}/{technicalQueries.Ncrid + 1}";

                var newAudit = new TblAuthList
                {
                    Title = "Non Conformance Report",
                    Status = (int)EReportStatus.OPEN,
                    StaffId = tblStaff.StaffId,
                    BatchId = Guid.NewGuid().ToString(),
                    CreatedDate = DateTime.UtcNow,
                    WfdefId = (int)EWorflowDefinition.NONCONFORMANCEREPORT,
                    EventType = (int)EEventType.NEW,
                    RecId = technicalQueries.Ncrid,
                    CompanyId = company.CompanyId
                };

                await _auditRepository.CreateAsync(newAudit);
                await _auditRepository.SaveChangesAsync();

                var srncrattachmentsTemps = new List<TblSrncrattachmentsTemp>();

                var drawingFile = reportFormtDto.NcrAttachments.DrawingFile;
                var ncrImage = reportFormtDto.NcrAttachments.NCRImages;
                var descriptionDoc = reportFormtDto.NcrAttachments.DescriptionDocuments;

                var max = Math.Max(drawingFile.Length, ncrImage.Length);
                max = Math.Max(max, descriptionDoc.Length);

                if (max > 0)
                {
                    for (int i = 0; i < max; i++)
                    {
                        var srncrattachmentsTemp = new TblSrncrattachmentsTemp
                        {
                            Ncrid = technicalQueries.Ncrid,
                            DrawingFile = (drawingFile.Length - 1 >= i)  ? drawingFile[i] : null,
                            ReferenceNumber = refNumber,
                            Ncrimages = (ncrImage.Length - 1 >= i) ? ncrImage[i] : null,
                            DescriptionDocuments = (descriptionDoc.Length - 1 >= i) ? descriptionDoc[i] : null,
                            CreatedDate = DateTime.UtcNow,
                            CreatedBy = tblStaff.StaffId.ToString()
                        };

                        srncrattachmentsTemps.Add(srncrattachmentsTemp);
                    }

                    await _context.TblSrncrattachmentsTemp.AddRangeAsync(srncrattachmentsTemps);
                    await _context.SaveChangesAsync();
                }

                var (checker, approver) = await _siteReportRepository.GetWorkflowApprovers(12);

                await _emailSender.SendEmailAsync(checker, "Non Conformance Technical Query Report tendered", "Log in to check the reports");

                await transaction.CommitAsync();

                return Ok(new SucessResponse<object>
                {
                    success = true,
                    message = "Non conformance report query created successfully",
                    data = new { }
                });
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                return StatusCode(500, Response<string>.InternalError(ex.Message));
            }
        }

        /// <summary>
        /// Endpoint to fetch list of CTQ by the current UserId
        /// </summary>
        /// <param name="parameters"></param>
        /// <returns></returns>
        [HttpGet("[action]", Name = "GetAllCTQ")]
        [ProducesResponseType(typeof(SucessResponse<IEnumerable<ConstructionTechnicalQueryDto>>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetAllCTQByUserId([FromQuery] CtqParameters parameters)
        {
            var userId = GetUserId();
            var tblStaff = await _staffRepository.FirstOrDefaultAsync(x => x.AspnetUserId == userId);

            var ctq = await _siteReportRepository.GetAllCTQ(tblStaff.StaffId, parameters);

            var prevLink = ctq.HasPrevious ? CreateResourceUri(parameters, ResourceUriType.PreviousPage) : null;
            var nextLink = ctq.HasNext ? CreateResourceUri(parameters, ResourceUriType.NextPage) : null;
            var currentLink = CreateResourceUri(parameters, ResourceUriType.CurrentPage);

            var pagination = new Pagination
            {
                currentPage = currentLink,
                nextPage = nextLink,
                previousPage = prevLink,
                totalPages = ctq.TotalPages,
                perPage = ctq.PageSize,
                totalEntries = ctq.TotalCount
            };

            return Ok(new PagedResponse<IEnumerable<ConstructionTechnicalQueryDto>>
            {
                success = true,
                message = "CTQ retrived successfully",
                data = ctq,
                meta = new Meta
                {
                    pagination = pagination
                }
            });
        }

        /// <summary>
        /// Endpoint to fetch all all CTQ with its list of CTQ replies
        /// between the Initiator and the Attendee
        /// </summary>
        /// <param name="ctqId"></param>
        /// <returns></returns>
        [HttpGet("[action]")]
        [ProducesResponseType(typeof(SucessResponse<IEnumerable<ConstructionTechnicalQueryRepliesDto>>), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ErrorResponse<object>), (int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> GetCTQReplies(int ctqId)
        {
            var ctqEntity = await _tblSrContructionTechnicalQueries.ExistsAsync(x => x.Ctqid == ctqId);

            if (!ctqEntity)
            {
                return NotFound(new ErrorResponse<object>
                {
                    success = false,
                    message = $"Construction technical query with ID: {ctqId} is not found",
                    errors = new { }
                });
            }

            var result = await _siteReportRepository.GetCTQByIdIncludeReplies(ctqId);

            return Ok(new SucessResponse<object>
            {
                success = true,
                message = "CTQ retrieved successfully",
                data = result
            });
        }

        #region CreateResource
        private string CreateResourceUri(CtqParameters parameters, ResourceUriType type)
        {
            switch (type)
            {
                case ResourceUriType.PreviousPage:
                    return Url.Link("GetAllCTQ",
                        new
                        {
                            PageNumber = parameters.PageNumber - 1,
                            parameters.PageSize,
                            parameters.CompanyId
                        });

                case ResourceUriType.NextPage:
                    return Url.Link("GetAllCTQ",
                        new
                        {
                            PageNumber = parameters.PageNumber + 1,
                            parameters.PageSize,
                            parameters.CompanyId
                        });

                default:
                    return Url.Link("GetAllCTQ",
                        new
                        {
                            parameters.PageNumber,
                            parameters.PageSize,
                            parameters.CompanyId
                        });
            }

        }
        #endregion
    }
}
