using JPSAGE_ERP.Application.Helpers;
using JPSAGE_ERP.Application.Models.SiteReporting;
using JPSAGE_ERP.Domain.Entities;
using System.Threading.Tasks;

namespace JPSAGE_ERP.Application.Interfaces
{
    public interface IAuthListRepository : IRepository<TblAuthList>
    {
        Task<PagedList<TblAuthList>> GetTransactionList(int staffId, AuthListParameters parameters);
        Task<GeneralSummaryDetailDto> GetGeneralSummaryDetail(int authId);
        Task<HseDetailDto> GetHseDetail(int authId);
        Task<OtherSiteDetialDto> GetOtherSiteDetialDetail(int authId);
        Task<ProgressPicturesDetailDto> GetProgressPicturesDetail(int authId);
        Task<ConstructionTechnicalDetailDto> GetConstructionTechnicalDetail(int authId);
        Task<ConstructionActivityDetailDto> GetConstructionActivityDetail(int authId);
        Task<DailyPGMeasurmentDetailDto> GetDailyPGMeasurmentDetail(int authId);
        Task<NonConformanceDetailDto> GetNonConformanceDetail(int authId);
    }
}
