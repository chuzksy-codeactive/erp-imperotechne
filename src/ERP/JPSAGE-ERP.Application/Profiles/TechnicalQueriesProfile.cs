using AutoMapper;
using JPSAGE_ERP.Application.Models.SiteReporting;
using JPSAGE_ERP.Domain.Entities;
using System;

namespace JPSAGE_ERP.Application.Profiles
{
    public class TechnicalQueriesProfile : Profile
    {
        public TechnicalQueriesProfile()
        {
            CreateMap<TechnicalQueriesFormDto, TblSrconstructionTechnicalQueriesTemp>()
                .AfterMap((src, dest) =>
                {
                    dest.CreatedDate = DateTime.Now;
                    dest.Ctqtitle = src.CtqTitle;
                    dest.Attention = src.AttendeeId;
                    dest.Ctqdescription = src.CtqDescription;
                });
        }
    }

    public class NonConformanceReportProfile : Profile
    {
        public NonConformanceReportProfile()
        {
            CreateMap<NonConformanceReporFormtDto, TblSrnonConformanceReportsTemp>();
        }
    }
}
