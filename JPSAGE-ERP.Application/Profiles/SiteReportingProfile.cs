using AutoMapper;
using JPSAGE_ERP.Application.Models.SiteReporting;
using JPSAGE_ERP.Domain.Entities;

namespace JPSAGE_ERP.Application.Profiles
{
    public class SiteReportingProfile : Profile
    {
        public SiteReportingProfile()
        {
            CreateMap<SrdrGeneralSummaryDto, TblSrdailyReportingGeneralSummaryTemp>();
            CreateMap<SrdrHSEReportDto, TblSrdailyReportHsetemp>();
            CreateMap<SrdrHSEAttachmentDto, TblSrdailyReportHseattachmentsTemp>();
            CreateMap<SrdrConstructionActivitiesDto, TblSrdailyReportingConstructionActivitiesTemp>();
            CreateMap<SrdrProgresssPicturesDto, TblSrdailyReportingProgressPicturesTemp>();
            CreateMap<SrdrOtherSiteReportDto, TblSrdailyReportOtherSiteReportsTemp>();

            CreateMap<SrdrHSEReportDto, TblSrdailyReportHsetemp>();
            CreateMap<SrdrHSEAttachmentDto, TblSrdailyReportHseattachmentsTemp>();
            CreateMap<SrdrConstructionActivitiesDto, TblSrdailyReportingConstructionActivitiesTemp>();

            CreateMap<SrdrProMeMasterDto, TblSrdailyReportProgressMeasurementMasterTemp>();
            CreateMap<SrdrProgressMeasurementDto, TblSrdailyReportProgressMeasurementDetailsTemp>();
            CreateMap<SrdrIssueDto, TblSrdailyReportingIssuesTemp>();
            CreateMap<SrdrDelayDto, TblSrdailyReportingDelaysTemp>();

            CreateMap<SrdrProgressMeasurementDto, TblSrdailyReportingProgressPicturesTemp>();
            CreateMap<SrdrOtherSiteReportDto, TblSrdailyReportOtherSiteReportsTemp>();
        }
    }
}
