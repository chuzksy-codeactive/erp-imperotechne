using JPSAGE_ERP.Application.Helpers;
using JPSAGE_ERP.Application.Interfaces;
using JPSAGE_ERP.Application.Models.SiteReporting;
using JPSAGE_ERP.Domain;
using JPSAGE_ERP.Domain.Entities;
using JPSAGE_ERP.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace JPSAGE_ERP.Application.Repository
{
    public class AuthListRepository : Repository<TblAuthList>, IAuthListRepository
    {
        public AuthListRepository(ApplicationDbContext context)
            : base(context)
        {
        }

        public async Task<GeneralSummaryDetailDto> GetGeneralSummaryDetail(int authId)
        {
            var auth = await _context.TblAuthList.FindAsync(authId);
            var staffRole = await _context.TblStaffRoles.FirstOrDefaultAsync(x => x.WfdefId == 12);
            var checker = await _context.TblStaffBioData.FirstOrDefaultAsync(x => x.StaffId == staffRole.CheckerId);
            var approver = await _context.TblStaffBioData.FirstOrDefaultAsync(x => x.StaffId == staffRole.AuthoriserId);

           
            var summary = await _context.TblSrdailyReportingGeneralSummaryTemp
                .Include(x => x.Company)
                .Include(x => x.Project)
                .FirstOrDefaultAsync(x => x.GenSumId == auth.RecId);

            var summaryDto = new GeneralSummaryDetailDto
            {
                GenSumId = summary.GenSumId,
                GeneralSummary = summary.GeneralSummary,
                CreatedDate = summary.CreatedDate,
                DocumentNumber = summary.DocumentNumber,
                Company = summary.Company?.CompanyName,
                Project = summary.Project?.ProjectName,
                AuthListDetail = new AuthListDetailsDto
                {
                    AuthId = auth.AuthId,
                    Title = auth.Title,
                    EventType = ((EEventType)auth.EventType).GetDescription(),
                    Status = ((EReportStatus)auth.Status).GetDescription(),
                    CreatedDate = auth.CreatedDate.Value,
                    StatusReason = auth.StatusReason,
                    CheckerStatus = auth.CheckerStatus != null ? ((EReportStatus)auth.CheckerStatus).GetDescription() : null,
                    CheckerStatusReason = auth.CheckerStatusReason,
                    ApproverStatus = auth.ApproverStatus != null ? ((EReportStatus)auth.ApproverStatus).GetDescription() : null,
                    ApproverStatusReason = auth.ApproverStatusReason,
                    Checker = $"{checker.FirstName} {checker.LastName}",
                    Approver = $"{approver.FirstName} {approver.LastName}",
                    CheckerId = checker.StaffId,
                    ApproverId = approver.StaffId
                }
            };

            return summaryDto;
        }

        public async Task<HseDetailDto> GetHseDetail(int authId)
        {
            var auth = await _context.TblAuthList.FindAsync(authId);
            var staffRole = await _context.TblStaffRoles.FirstOrDefaultAsync(x => x.WfdefId == 12);
            var checker = await _context.TblStaffBioData.FirstOrDefaultAsync(x => x.StaffId == staffRole.CheckerId);
            var approver = await _context.TblStaffBioData.FirstOrDefaultAsync(x => x.StaffId == staffRole.AuthoriserId);


            var hse = await _context.TblSrdailyReportHseattachmentsTemp.FirstOrDefaultAsync(x => x.DrhseattId == auth.RecId);

            var hseDto = new HseDetailDto
            {
                DrhseattId = hse.DrhseattId,
                CreatedDate = hse.CreatedDate,
                PermitToWork = hse.PermitToWork,
                SecurityReport = hse.SecurityReport,
                AuthListDetail = new AuthListDetailsDto
                {
                    AuthId = auth.AuthId,
                    Title = auth.Title,
                    EventType = ((EEventType)auth.EventType).GetDescription(),
                    Status = ((EReportStatus)auth.Status).GetDescription(),
                    CreatedDate = auth.CreatedDate.Value,
                    StatusReason = auth.StatusReason,
                    CheckerStatus = auth.CheckerStatus != null ? ((EReportStatus)auth.CheckerStatus).GetDescription() : null,
                    CheckerStatusReason = auth.CheckerStatusReason,
                    ApproverStatus = auth.ApproverStatus != null ? ((EReportStatus)auth.ApproverStatus).GetDescription() : null,
                    ApproverStatusReason = auth.ApproverStatusReason,
                    Checker = $"{checker.FirstName} {checker.LastName}",
                    Approver = $"{approver.FirstName} {approver.LastName}",
                    CheckerId = checker.StaffId,
                    ApproverId = approver.StaffId
                }
            };

            return hseDto;
        }
        public async Task<OtherSiteDetialDto> GetOtherSiteDetialDetail(int authId)
        {
            var auth = await _context.TblAuthList.FindAsync(authId);
            var staffRole = await _context.TblStaffRoles.FirstOrDefaultAsync(x => x.WfdefId == 12);
            var checker = await _context.TblStaffBioData.FirstOrDefaultAsync(x => x.StaffId == staffRole.CheckerId);
            var approver = await _context.TblStaffBioData.FirstOrDefaultAsync(x => x.StaffId == staffRole.AuthoriserId);

            var other = await _context.TblSrdailyReportOtherSiteReportsTemp
                .Include(x => x.Company)
                .Include(x => x.Project)
                .FirstOrDefaultAsync(x => x.OsrepId == auth.RecId);

            var otherDto = new OtherSiteDetialDto
            {
                OsrepId = other.OsrepId,
                Qaqcreport = other.Qaqcreport,
                LogisticsReport = other.LogisticsReport,
                SitePersonnelLogReport = other.SitePersonnelLogReport,
                MaterialReport = other.MaterialReport,
                Mocreport = other.Mocreport,
                CreatedDate = other.CreatedDate,
                DocumentNumber = other.DocumentNumber,
                Company = other.Company?.CompanyName,
                Project = other.Project?.ProjectName,
                AuthListDetail = new AuthListDetailsDto
                {
                    AuthId = auth.AuthId,
                    Title = auth.Title,
                    EventType = ((EEventType)auth.EventType).GetDescription(),
                    Status = ((EReportStatus)auth.Status).GetDescription(),
                    CreatedDate = auth.CreatedDate.Value,
                    StatusReason = auth.StatusReason,
                    CheckerStatus = auth.CheckerStatus != null ? ((EReportStatus)auth.CheckerStatus).GetDescription() : null,
                    CheckerStatusReason = auth.CheckerStatusReason,
                    ApproverStatus = auth.ApproverStatus != null ? ((EReportStatus)auth.ApproverStatus).GetDescription() : null,
                    ApproverStatusReason = auth.ApproverStatusReason,
                    Checker = $"{checker.FirstName} {checker.LastName}",
                    Approver = $"{approver.FirstName} {approver.LastName}",
                    CheckerId = checker.StaffId,
                    ApproverId = approver.StaffId
                }
            };

            return otherDto;
        }

        public async Task<PagedList<TblAuthList>> GetTransactionList(int staffId, AuthListParameters parameters)
        {
            // Check if the staff is a Checker or Approver
            var staffRole = await _context.TblStaffRoles.FirstOrDefaultAsync(x => x.WfdefId == 12);

            var checker = new TblStaffBioData();
            var approver = new TblStaffBioData();

            if (staffRole != null)
            {
                checker = await _context.TblStaffBioData.FirstOrDefaultAsync(x => x.StaffId == staffRole.CheckerId);
                approver = await _context.TblStaffBioData.FirstOrDefaultAsync(x => x.StaffId == staffRole.AuthoriserId);
            }

            var query = _context.TblAuthList as IQueryable<TblAuthList>;

            if (checker.StaffId == staffId || approver.StaffId == staffId)
            {
                query.Where(x => x.StaffId == checker.StaffId || x.StaffId == approver.StaffId);
            }
            else
            {
                query = query.Where(x => x.StaffId == staffId);
            }

            if (!string.IsNullOrEmpty(parameters.Search))
            {
                var search = parameters.Search.Trim();
                query = query.Where(x => x.Title.Contains(search));
            }

            var authList = await PagedList<TblAuthList>.Create(query, parameters.PageNumber, parameters.PageSize);

            return authList;
        }

        public async Task<ProgressPicturesDetailDto> GetProgressPicturesDetail(int authId)
        {
            var auth = await _context.TblAuthList.FindAsync(authId);
            var staffRole = await _context.TblStaffRoles.FirstOrDefaultAsync(x => x.WfdefId == 12);
            var checker = await _context.TblStaffBioData.FirstOrDefaultAsync(x => x.StaffId == staffRole.CheckerId);
            var approver = await _context.TblStaffBioData.FirstOrDefaultAsync(x => x.StaffId == staffRole.AuthoriserId);


            var pp = await _context.TblSrdailyReportingProgressPicturesTemp
                .Include(x => x.Company)
                .Include(x => x.Project)
                .FirstOrDefaultAsync(x => x.Ppid == auth.RecId);

            var otherDto = new ProgressPicturesDetailDto
            {
                Ppid = pp.Ppid,
                CreatedDate = pp.CreatedDate,
                DocumentNumber = pp.DocumentNumber,
                Company = pp.Company?.CompanyName,
                Project = pp.Project?.ProjectName,
                AuthListDetail = new AuthListDetailsDto
                {
                    AuthId = auth.AuthId,
                    Title = auth.Title,
                    EventType = ((EEventType)auth.EventType).GetDescription(),
                    Status = ((EReportStatus)auth.Status).GetDescription(),
                    CreatedDate = auth.CreatedDate.Value,
                    StatusReason = auth.StatusReason,
                    CheckerStatus = auth.CheckerStatus != null ? ((EReportStatus)auth.CheckerStatus).GetDescription() : null,
                    CheckerStatusReason = auth.CheckerStatusReason,
                    ApproverStatus = auth.ApproverStatus != null ? ((EReportStatus)auth.ApproverStatus).GetDescription() : null,
                    ApproverStatusReason = auth.ApproverStatusReason,
                    Checker = $"{checker.FirstName} {checker.LastName}",
                    Approver = $"{approver.FirstName} {approver.LastName}",
                    CheckerId = checker.StaffId,
                    ApproverId = approver.StaffId
                }
            };

            return otherDto;
        }

        public async Task<ConstructionTechnicalDetailDto> GetConstructionTechnicalDetail(int authId)
        {
            var auth = await _context.TblAuthList.FindAsync(authId);
            var staffRole = await _context.TblStaffRoles.FirstOrDefaultAsync(x => x.WfdefId == 11);
            var checker = await _context.TblStaffBioData.FirstOrDefaultAsync(x => x.StaffId == staffRole.CheckerId);
            var approver = await _context.TblStaffBioData.FirstOrDefaultAsync(x => x.StaffId == staffRole.AuthoriserId);


            var tech = await _context.TblSrconstructionTechnicalQueriesTemp
                .Include(x => x.Project)
                .FirstOrDefaultAsync(x => x.Ctqid == auth.RecId);

            var otherDto = new ConstructionTechnicalDetailDto
            {
                Ctqid = tech.Ctqid,
                Ctqtitle = tech.Ctqtitle,
                Ctqnumber = tech.Ctqnumber,
                QueryDate = tech.QueryDate,
                Ctqdescription = tech.Ctqdescription,
                Attention = tech.Attention,
                Project = tech.Project?.ProjectName,
                AuthListDetail = new AuthListDetailsDto
                {
                    AuthId = auth.AuthId,
                    Title = auth.Title,
                    EventType = ((EEventType)auth.EventType).GetDescription(),
                    Status = ((EReportStatus)auth.Status).GetDescription(),
                    CreatedDate = auth.CreatedDate.Value,
                    StatusReason = auth.StatusReason,
                    CheckerStatus = auth.CheckerStatus != null ? ((EReportStatus)auth.CheckerStatus).GetDescription() : null,
                    CheckerStatusReason = auth.CheckerStatusReason,
                    ApproverStatus = auth.ApproverStatus != null ? ((EReportStatus)auth.ApproverStatus).GetDescription() : null,
                    ApproverStatusReason = auth.ApproverStatusReason,
                    Checker = $"{checker.FirstName} {checker.LastName}",
                    Approver = $"{approver.FirstName} {approver.LastName}",
                    CheckerId = checker.StaffId,
                    ApproverId = approver.StaffId
                }
            };

            return otherDto;
        }

        public async Task<ConstructionActivityDetailDto> GetConstructionActivityDetail(int authId)
        {
            var auth = await _context.TblAuthList.FindAsync(authId);
            var staffRole = await _context.TblStaffRoles.FirstOrDefaultAsync(x => x.WfdefId == 12);
            var checker = await _context.TblStaffBioData.FirstOrDefaultAsync(x => x.StaffId == staffRole.CheckerId);
            var approver = await _context.TblStaffBioData.FirstOrDefaultAsync(x => x.StaffId == staffRole.AuthoriserId);


            var activity = await _context.TblSrdailyReportingConstructionActivitiesTemp
                .Include(x => x.Company)
                .Include(x => x.Project)
                .FirstOrDefaultAsync(x => x.DrconActId == auth.RecId);

            var activityDto = new ConstructionActivityDetailDto
            {
                DrconActId = activity.DrconActId,
                ConstructionActivities = activity.ConstructionActivities,
                DailyProgress = activity.DailyProgress,
                FollowingDayPlan = activity.FollowingDayPlan,
                DocumentNumber = activity.DocumentNumber,
                Company = activity.Company?.CompanyName,
                Project = activity.Project?.ProjectName,
                AuthListDetail = new AuthListDetailsDto
                {
                    AuthId = auth.AuthId,
                    Title = auth.Title,
                    EventType = ((EEventType)auth.EventType).GetDescription(),
                    Status = ((EReportStatus)auth.Status).GetDescription(),
                    CreatedDate = auth.CreatedDate.Value,
                    StatusReason = auth.StatusReason,
                    CheckerStatus = auth.CheckerStatus != null ? ((EReportStatus)auth.CheckerStatus).GetDescription() : null,
                    CheckerStatusReason = auth.CheckerStatusReason,
                    ApproverStatus = auth.ApproverStatus != null ? ((EReportStatus)auth.ApproverStatus).GetDescription() : null,
                    ApproverStatusReason = auth.ApproverStatusReason,
                    Checker = $"{checker.FirstName} {checker.LastName}",
                    Approver = $"{approver.FirstName} {approver.LastName}",
                    CheckerId = checker.StaffId,
                    ApproverId = approver.StaffId
                }
            };

            return activityDto;
        }

        public async Task<DailyPGMeasurmentDetailDto> GetDailyPGMeasurmentDetail(int authId)
        {
            var auth = await _context.TblAuthList.FindAsync(authId);
            var staffRole = await _context.TblStaffRoles.FirstOrDefaultAsync(x => x.WfdefId == 12);
            var checker = await _context.TblStaffBioData.FirstOrDefaultAsync(x => x.StaffId == staffRole.CheckerId);
            var approver = await _context.TblStaffBioData.FirstOrDefaultAsync(x => x.StaffId == staffRole.AuthoriserId);


            var pg = await _context.TblSrdailyReportProgressMeasurementMasterTemp
                .Include(x => x.Company)
                .Include(x => x.Project)
                .FirstOrDefaultAsync(x => x.ProMeMasterId == auth.RecId);

            var otherDto = new DailyPGMeasurmentDetailDto
            {
                ProMeMasterId = pg.ProMeMasterId,
                ProgressAt = pg.ProgressAt,
                ConstructionActual = pg.ConstructionActual,
                Planned = pg.Planned,
                DocumentNumber = pg.DocumentNumber,
                Company = pg.Company.CompanyName,
                Project = pg.Project.ProjectName,
                AuthListDetail = new AuthListDetailsDto
                {
                    AuthId = auth.AuthId,
                    Title = auth.Title,
                    EventType = ((EEventType)auth.EventType).GetDescription(),
                    Status = ((EReportStatus)auth.Status).GetDescription(),
                    CreatedDate = auth.CreatedDate.Value,
                    StatusReason = auth.StatusReason,
                    CheckerStatus = auth.CheckerStatus != null ? ((EReportStatus)auth.CheckerStatus).GetDescription() : null,
                    CheckerStatusReason = auth.CheckerStatusReason,
                    ApproverStatus = auth.ApproverStatus != null ? ((EReportStatus)auth.ApproverStatus).GetDescription() : null,
                    ApproverStatusReason = auth.ApproverStatusReason,
                    Checker = $"{checker.FirstName} {checker.LastName}",
                    Approver = $"{approver.FirstName} {approver.LastName}",
                    CheckerId = checker.StaffId,
                    ApproverId = approver.StaffId
                }
            };

            return otherDto;
        }

        public async Task<NonConformanceDetailDto> GetNonConformanceDetail(int authId)
        {
            var auth = await _context.TblAuthList.FindAsync(authId);
            var staffRole = await _context.TblStaffRoles.FirstOrDefaultAsync(x => x.WfdefId == 13);
            var checker = await _context.TblStaffBioData.FirstOrDefaultAsync(x => x.StaffId == staffRole.CheckerId);
            var approver = await _context.TblStaffBioData.FirstOrDefaultAsync(x => x.StaffId == staffRole.AuthoriserId);


            var nonCon = await _context.TblSrnonConformanceReportsTemp
                .Include(x => x.Project)
                .Include(x => x.Supplier)
                .FirstOrDefaultAsync(x => x.Ncrid == auth.RecId);

            var nonConDto = new NonConformanceDetailDto
            {
                Ncrid = nonCon.Ncrid,
                Title = nonCon.Title,
                ReportNumber = nonCon.ReportNumber,
                Item = nonCon.Item,
                SystemsSubSystems = nonCon.SystemsSubSystems,
                Supplier = nonCon.Supplier.CompanyName,
                ReqEngApproval = nonCon.ReqEngApproval,
                IssuedBy = nonCon.IssuedBy,
                IssuedDate = nonCon.IssuedDate,
                Description = nonCon.Description,
                DocumentNumber = nonCon.DocumentNumber,
                Project = nonCon.Project?.ProjectName,
                AuthListDetail = new AuthListDetailsDto
                {
                    AuthId = auth.AuthId,
                    Title = auth.Title,
                    EventType = ((EEventType)auth.EventType).GetDescription(),
                    Status = ((EReportStatus)auth.Status).GetDescription(),
                    CreatedDate = auth.CreatedDate.Value,
                    StatusReason = auth.StatusReason,
                    CheckerStatus = auth.CheckerStatus != null ? ((EReportStatus)auth.CheckerStatus).GetDescription() : null,
                    CheckerStatusReason = auth.CheckerStatusReason,
                    ApproverStatus = auth.ApproverStatus != null ? ((EReportStatus)auth.ApproverStatus).GetDescription() : null,
                    ApproverStatusReason = auth.ApproverStatusReason,
                    Checker = $"{checker.FirstName} {checker.LastName}",
                    Approver = $"{approver.FirstName} {approver.LastName}",
                    CheckerId = checker.StaffId,
                    ApproverId = approver.StaffId
                }
            };

            return nonConDto;
        }
    }
}
