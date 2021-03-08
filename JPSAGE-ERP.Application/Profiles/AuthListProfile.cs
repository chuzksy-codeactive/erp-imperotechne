using AutoMapper;
using JPSAGE_ERP.Application.Helpers;
using JPSAGE_ERP.Application.Models.SiteReporting;
using JPSAGE_ERP.Domain.Entities;
using JPSAGE_ERP.Domain.Enums;

namespace JPSAGE_ERP.Application.Profiles
{
    public class AuthListProfile : Profile
    {
        public AuthListProfile()
        {
            CreateMap<TblAuthList, AuthListDto>()
                .AfterMap((src, dest) =>
                {
                    dest.Status = src.Status == null ? null : ((EReportStatus)src.Status).GetDescription();
                    dest.EventType = src.EventType == null ? null : ((EEventType)src.EventType).GetDescription();
                    dest.WfDefId = src.WfdefId == null ? default : src.WfdefId.Value;
                });
        }
    }
}
