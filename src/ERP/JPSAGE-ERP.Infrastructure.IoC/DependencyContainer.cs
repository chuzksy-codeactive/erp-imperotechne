using AutoMapper;
using FluentValidation;
using FluentValidation.AspNetCore;
using JPSAGE_ERP.Application.Interfaces;
using JPSAGE_ERP.Application.Models.Account;
using JPSAGE_ERP.Application.Models.SiteReporting;
using JPSAGE_ERP.Application.Repository;
using JPSAGE_ERP.Application.Services;
using JPSAGE_ERP.Application.Validators;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace JPSAGE_ERP.Infrastructure.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            // DI for FluentValidator
            services.AddMvc().AddFluentValidation(x => x.RegisterValidatorsFromAssemblyContaining<DailyReportFormDTOValidator>());
            services.AddTransient<IValidator<DailyReportFormDTO>, DailyReportFormDTOValidator>();
            services.AddTransient<IValidator<TechnicalQueriesFormDto>, TechnicalQueriesFormDtoValidator>();
            services.AddTransient<IValidator<AttentionReplyFormDto>, AttiontionReplyFormDtoValidator>();
            services.AddTransient<IValidator<InitiatorReplyFormDto>, InitiatorReplyFormDtoValidator>();
            services.AddTransient<IValidator<NonConformanceReporFormtDto>, NonConformanceReportDtoValidator>();

            services.AddTransient<IValidator<SrdrGeneralSummaryDto>, SrdrGeneralSummaryDtoValidator>();
            services.AddTransient<IValidator<SrdrHseReportAttachmentDto>, SrdrHseReportAttachmentDtoValidator>();
            services.AddTransient<IValidator<SrdrConstructionActivitiesDto>, SrdrConstructionActivitiesDtoValidator>();
            services.AddTransient<IValidator<SrdrProgresssPicturesDto>, SrdrProgresssPicturesDtoValidator>();
            services.AddTransient<IValidator<SrdrOtherSiteReportDto>, SrdrOtherSiteReportDtoValidator>();
            services.AddTransient<IValidator<ChangePasswordDto>, ChangePasswordDtoValidator>();
            services.AddTransient<IValidator<RegisterViewModel>, RegisterViewModelValidator>();

            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<ISiteReportRepository, SiteReportRepository>();
            services.AddScoped<IAuthListRepository, AuthListRepository>();
            services.AddSingleton<IEmailSender, EmailSender>();
            services.AddScoped<IUploadFileToBlob, UploadFileToBlob>();
            services.AddScoped<IFileContentUploadService, FileContentUploadService>();
            services.AddScoped<IEmailTemplate, EmailTemplate>();
            services.AddScoped(typeof(IMtoRepository), typeof(MtoRepository));
            services.AddTransient<IMtoRepository, MtoRepository>();
        }
    }
}
