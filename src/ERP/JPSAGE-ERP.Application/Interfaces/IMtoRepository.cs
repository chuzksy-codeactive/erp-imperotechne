using JPSAGE_ERP.Application.Helpers;
using JPSAGE_ERP.Application.Models;
using JPSAGE_ERP.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace JPSAGE_ERP.Application.Interfaces
{
    public interface IMtoRepository
    {
        Task CreateMaterialTakeOff(MtoDto mto);
        Task<PagedList<TblMtoformsTemp>> GetAllMaterialTakeOffs(int userId, MtoParameters parameters);
        Task<MtoDto> GetMaterialTakeOff(int mtoId);
        Task<IEnumerable<MtoDisciplineDto>> GetMtoDiscipline();
        Task<IEnumerable<MtoSubdisciplineDto>> GetMtosubDisciplines(int mtoDisciplineId);
    }
}
