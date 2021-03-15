using Cache.API.Entities;
using Cache.API.Helpers;
using Cache.API.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cache.API.Repositories.Interface
{
    public interface IMtoRepository
    {
        Task<SuccessResponse<MaterialTakeOffDto>> GetMaterialTakeOffs(string username);
        Task<SuccessResponse<IEnumerable<object>>> GetMTODetails(string username);
        Task<SuccessResponse<object>> CreateMTO(string username, MaterialTakeOffDto materialTakeOff);
        Task<SuccessResponse<object>> AddSingleMTODetails(string username, MtoDisciplineDetailDto materialTakeOffDetail);
        Task<SuccessResponse<object>> AddMultipleMTODetails(string username, MtoDisciplineDetailsDto materialTakeOffDetails);
        Task<SuccessResponse<object>> UpdateMTO(string username, MaterialTakeOffDto materialTakeOff);
        Task<SuccessResponse<object>> UpdateMTODetails(string username, MtoDisciplineDetailsDto mtoDetail);
        Task<SuccessResponse<object>> DeleteMTO(string username);
        Task<SuccessResponse<object>> ClearMTODetails(string username);
        Task<SuccessResponse<object>> RemoveMTOItem(string username, Guid itemid);
    }
}
