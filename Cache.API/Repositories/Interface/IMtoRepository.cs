using Cache.API.Entities;
using Cache.API.Helpers;
using Cache.API.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cache.API.Repositories.Interface
{
    public interface IMtoRepository
    {
        Task<SuccessResponse<MaterialTakeOffDto>> GetMaterialTakeOffs(string username);
        Task<SuccessResponse<IEnumerable<MaterialTakeOffDetailDto>>> GetMTODetails(string username);
        Task<SuccessResponse<object>> CreateMTO(string username, MaterialTakeOff materialTakeOff);
        Task<SuccessResponse<object>> AddSingleMTODetails(string username, MaterialTakeOffDetail materialTakeOffDetail);
        Task<SuccessResponse<object>> AddMultipleMTODetails(string username, ICollection<MaterialTakeOffDetail> materialTakeOffDetails);
        Task<SuccessResponse<object>> UpdateMTO(string username, MaterialTakeOff materialTakeOff);
        Task<SuccessResponse<object>> UpdateMTODetails(string username, ICollection<MaterialTakeOffDetail> mtoDetail);
        Task<SuccessResponse<object>> DeleteMTO(string username);
        Task<SuccessResponse<object>> ClearMTODetails(string username);
    }
}
