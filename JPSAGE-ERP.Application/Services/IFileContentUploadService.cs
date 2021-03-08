using JPSAGE_ERP.Application.Models.Responses;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace JPSAGE_ERP.Application.Services
{
    public interface IFileContentUploadService
    {
        Task<FileResponse> SingleFileUpload(IFormFile file);
        Task<MultipleFileResponse> MultipleFileUpload(IFormFileCollection files);
    }
}
