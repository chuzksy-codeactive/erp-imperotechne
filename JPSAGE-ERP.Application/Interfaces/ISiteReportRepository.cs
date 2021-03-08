using JPSAGE_ERP.Application.Helpers;
using JPSAGE_ERP.Application.Models.Miscellaneous;
using JPSAGE_ERP.Application.Models.SiteReporting;
using JPSAGE_ERP.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace JPSAGE_ERP.Application.Interfaces
{
    public interface ISiteReportRepository : IRepository<TblStaffBioData>
    {
        Task<(string checker, string authorizer)> GetWorkflowApprovers(int wfdefId);
        Task<IEnumerable<TSrconstructionTechnicalQueriesTempDto>> GetAllSRCTQReplies();
        Task<IEnumerable<TSrconstructionTechnicalQueriesTempDto>> GetAllSRCTQRepliesForAttentee(int attendeeId);
        Task<IEnumerable<TSrconstructionTechnicalQueriesTempDto>> GetAllSRCTQRepliesForInitiator(int attendeeId);
        Task<IEnumerable<CompanyInfoDto>> GetAllCompanyInfo();
        Task<PagedList<ConstructionTechnicalQueryDto>> GetAllCTQ(int userId, CtqParameters parameters);
        Task<TblSrconstructionTechnicalQueryRepliesTemp> GetCTQByIdDescOrder(int ctqId);
        Task<ConstructionTechnicalQueryRepliesDto> GetCTQByIdIncludeReplies(int ctqId);
    }
}
