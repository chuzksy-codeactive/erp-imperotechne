using JPSAGE_ERP.Application.Models.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace JPSAGE_ERP.Application.Services
{
    /// <summary>
    /// The class is used for file upload into the 
    /// Azure blob storage
    /// </summary>
    public class FileContentUploadService : IFileContentUploadService
    {
        private readonly string containerName = "vendors";
        public FileContentUploadService(
            IConfiguration configuration)
        {
            Configuration = configuration;
        }

        private IConfiguration Configuration { get; }


        /// <summary>
        /// Method to upload multiple files
        /// </summary>
        /// <param name="files"></param>
        /// <returns></returns>
        public async Task<MultipleFileResponse> MultipleFileUpload(IFormFileCollection files)
        {
            var errors = MultipleFileContentValidator(files);

            if (errors.Count > 0)
            {
                return new MultipleFileResponse
                {
                    Success = false,
                    Messages = errors,
                    Urls = null
                };
            }

            var account = CloudStorageAccount.Parse(Configuration["AzureBlobConnectionString"]);
            var client = account.CreateCloudBlobClient();

            var container = client.GetContainerReference(containerName);
            await container.CreateIfNotExistsAsync();

            await container.SetPermissionsAsync(new BlobContainerPermissions
            {
                PublicAccess = BlobContainerPublicAccessType.Blob
            });

            byte[] content;
            List<string> urls = new List<string>();

            foreach (var file in files)
            {
                using (var memoryStream = new MemoryStream())
                {
                    await file.CopyToAsync(memoryStream);
                    content = memoryStream.ToArray();
                }

                var extension = Path.GetFileNameWithoutExtension(file.FileName);

                var fileName = $"{Guid.NewGuid()}-{extension}";
                fileName = fileName.Replace(" ", "-");
                var blob = container.GetBlockBlobReference(fileName);

                await blob.UploadFromByteArrayAsync(content, 0, content.Length);
                blob.Properties.ContentType = file.ContentType;

                await blob.SetPropertiesAsync();

                urls.Add(blob.Uri.ToString());
            }

            return new MultipleFileResponse
            {
                Success = true,
                Messages = null,
                Urls = urls
            };
        }

        /// <summary>
        /// Method to upload a single file
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        public async Task<FileResponse> SingleFileUpload(IFormFile file)
        {
            var error = FileContentValidator(file);

            if (!string.IsNullOrEmpty(error))
            {
                return new FileResponse
                {
                    Success = false,
                    Message = error,
                    Url = null
                };
            }

            byte[] content;

            using (var memoryStream = new MemoryStream())
            {
                await file.CopyToAsync(memoryStream);
                content = memoryStream.ToArray();
            }

            var extension = Path.GetFileNameWithoutExtension(file.FileName);

            var account = CloudStorageAccount.Parse(Configuration["AzureBlobConnectionString"]);
            var client = account.CreateCloudBlobClient();

            var container = client.GetContainerReference(containerName);
            await container.CreateIfNotExistsAsync();

            await container.SetPermissionsAsync(new BlobContainerPermissions
            {
                PublicAccess = BlobContainerPublicAccessType.Blob
            });

            var fileName = $"{Guid.NewGuid()}-{extension}";
            fileName = fileName.Replace(" ", "-");
            var blob = container.GetBlockBlobReference(fileName);

            await blob.UploadFromByteArrayAsync(content, 0, content.Length);
            blob.Properties.ContentType = file.ContentType;

            await blob.SetPropertiesAsync();
            var fileResponse = new FileResponse()
            {
                Success = true,
                Message = "File content uploaded successfully",
                Url = blob.Uri.ToString()
            };
            return fileResponse;
        }

        /// <summary>
        /// Method used to validate a single file to upload
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        private string FileContentValidator(IFormFile file)
        {
            string fileFormat = Configuration["FileFormat"];
            long fileSize = long.Parse(Configuration["FileSize"]);

            var error = string.Empty;

            if (file != null && file.Length > 0)
            {
                var extension = Path.GetExtension(file.FileName);

                if (!fileFormat.Contains(extension.ToLower()))
                {
                    error = "The file type is not recognized";
                }

                if (fileSize < file.Length)
                {
                    error = "File size cannot be bigger than 10 megabytes";
                }
            }

            return error;
        }

        /// <summary>
        /// Method to validate multiple files
        /// </summary>
        /// <param name="files"></param>
        /// <returns></returns>
        public Dictionary<string, string> MultipleFileContentValidator(IFormFileCollection files)
        {
            var errors = new Dictionary<string, string>();
            var invalidFiles = new List<IFormFile>();

            if (files.Count > 0)
            {

                for (int i = 0; i < files.Count; i++)
                {
                    if (files[i] != null && files[i].Length > 0)
                    {
                        var extension = Path.GetExtension(files[i].FileName);
                        string fileFormat = Configuration["FileFormat"];
                        long fileSize = long.Parse(Configuration["FileSize"]);

                        if (!fileFormat.Contains(extension.ToLower()))
                        {
                            errors.Add($"File[{Array.IndexOf(files.ToArray(), files[i])}]", $"{Path.GetFileNameWithoutExtension(files[i].FileName)} file failed to upload");
                            invalidFiles.Add(files[i]);
                        }

                        if (fileSize < files[i].Length)
                        {
                            errors.Add($"File[{Array.IndexOf(files.ToArray(), files[i])}]", $"{Path.GetFileNameWithoutExtension(files[i].FileName)} file size is should not be more than 10mb");
                            invalidFiles.Add(files[i]);
                        }
                    }
                }
            }

            return errors;
        }
    }
}
