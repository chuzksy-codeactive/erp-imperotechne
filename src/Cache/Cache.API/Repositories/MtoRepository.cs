using AutoMapper;
using Cache.API.Data.Interface;
using Cache.API.Entities;
using Cache.API.Helpers;
using Cache.API.Model;
using Cache.API.Repositories.Interface;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace Cache.API.Repositories
{
    public class MtoRepository : IMtoRepository
    {
        private readonly ICacheContext _context;
        private readonly IMapper _mapper;
        public MtoRepository(ICacheContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<SuccessResponse<IEnumerable<MaterialTakeOffDetailDto>>> GetMTODetails(string username)
        {
            var mto = await _context
                .Redis
                .StringGetAsync(username);

            if (mto.IsNullOrEmpty)
            {
                throw new RestException(HttpStatusCode.NotFound, ResponseMessages.DataNotFound);
            }

            var result = JsonConvert.DeserializeObject<MaterialTakeOff>(mto);

            var mtoDto = _mapper.Map<MaterialTakeOffDto>(result);

            return new SuccessResponse<IEnumerable<MaterialTakeOffDetailDto>>
            {
                Message = ResponseMessages.RetrievalSuccessResponse,
                Data = mtoDto.MaterialTakeOffDetails
            };
        }

        public async Task<SuccessResponse<MaterialTakeOffDto>> GetMaterialTakeOffs(string username)
        {
            var mto = await _context
                .Redis
                .StringGetAsync(username);

            if (mto.IsNullOrEmpty)
            {
                throw new RestException(HttpStatusCode.NotFound, ResponseMessages.DataNotFound);
            }

            var result = JsonConvert.DeserializeObject<MaterialTakeOff>(mto);

            var mtoDto = _mapper.Map<MaterialTakeOffDto>(result);

            return new SuccessResponse<MaterialTakeOffDto>
            {
                Message = ResponseMessages.RetrievalSuccessResponse,
                Data = mtoDto
            };
        }

        public async Task<SuccessResponse<object>> CreateMTO(string username, MaterialTakeOff materialTakeOff)
        {
            var mto = await _context
                .Redis
                .StringSetAsync(username, JsonConvert.SerializeObject(materialTakeOff));

            if (!mto)
            {
                throw new RestException(HttpStatusCode.BadRequest, ResponseMessages.InvalidObject);
            }

            return new SuccessResponse<object>
            {
                Message = ResponseMessages.CreationSuccessResponse,
                Data = new {}
            };
        }

        public async Task<SuccessResponse<object>> AddSingleMTODetails(string username, MaterialTakeOffDetail materialTakeOffDetail)
        {
            var getMtoDto = await GetMaterialTakeOffs(username);

            if (getMtoDto == null)
            {
                throw new RestException(HttpStatusCode.NotFound, ResponseMessages.DataNotFound);
            }

            var getMto = _mapper.Map<MaterialTakeOff>(getMtoDto.Data);

            getMto.MaterialTakeOffDetails.Add(materialTakeOffDetail);

            var mto = await _context
                .Redis
                .StringSetAsync(username, JsonConvert.SerializeObject(getMto));

            if (!mto)
            {
                throw new RestException(HttpStatusCode.BadRequest, ResponseMessages.InvalidObject);
            }

            return new SuccessResponse<object>
            {
                Message = ResponseMessages.ItemAddedSuccessResponse,
                Data = new {}
            };
        }

        public async Task<SuccessResponse<object>> AddMultipleMTODetails(string username, ICollection<MaterialTakeOffDetail> materialTakeOffDetails)
        {
            var getMtoDto = await GetMaterialTakeOffs(username);

            if (getMtoDto == null)
            {
                throw new RestException(HttpStatusCode.NotFound, ResponseMessages.DataNotFound);
            }

            var getMto = _mapper.Map<MaterialTakeOff>(getMtoDto.Data);

            foreach (var mtoDetail in materialTakeOffDetails)
            {
                getMto.MaterialTakeOffDetails.Add(mtoDetail);
            }

            var mto = await _context
                .Redis
                .StringSetAsync(username, JsonConvert.SerializeObject(getMto));

            if (!mto)
            {
                throw new RestException(HttpStatusCode.BadRequest, ResponseMessages.InvalidObject);
            }

            return new SuccessResponse<object>
            {
                Message = ResponseMessages.CreationSuccessResponse,
                Data = new {}
            };
        }

        public async Task<SuccessResponse<object>> UpdateMTO(string username, MaterialTakeOff materialTakeOff)
        {
            var mto = await _context
                .Redis
                .StringSetAsync(username, JsonConvert.SerializeObject(materialTakeOff));

            if (!mto)
            {
                throw new RestException(HttpStatusCode.BadRequest, ResponseMessages.InvalidObject);
            }

            return new SuccessResponse<object>
            {
                Message = ResponseMessages.UpdateSuccessResponse,
                Data = new { }
            };
        }

        public async Task<SuccessResponse<object>> UpdateMTODetails(string username, ICollection<MaterialTakeOffDetail> mtoDetails)
        {
            var getMtoDto = await GetMaterialTakeOffs(username);

            if (getMtoDto == null)
            {
                throw new RestException(HttpStatusCode.NotFound, ResponseMessages.DataNotFound);
            }

            var getMto = _mapper.Map<MaterialTakeOff>(getMtoDto.Data);

            getMto.MaterialTakeOffDetails = mtoDetails;

            var mto = await _context
                .Redis
                .StringSetAsync(username, JsonConvert.SerializeObject(getMto));

            if (!mto)
            {
                throw new RestException(HttpStatusCode.BadRequest, ResponseMessages.InvalidObject);
            }

            return new SuccessResponse<object>
            {
                Message = ResponseMessages.UpdateSuccessResponse,
                Data = new { }
            };
        }

        public async Task<SuccessResponse<object>> DeleteMTO(string username)
        {
            var result = await _context
                .Redis
                .KeyDeleteAsync(username);

            if (!result)
            {
                throw new RestException(HttpStatusCode.BadRequest, ResponseMessages.DeleteUnSuccessResponse);
            }

            return new SuccessResponse<object>
            {
                Message = ResponseMessages.DeleteSuccessResponse,
                Data = new { }
            };
        }

        public async Task<SuccessResponse<object>> ClearMTODetails(string username)
        {
            var getMto = await GetMaterialTakeOffs(username);

            if (getMto == null)
            {
                throw new RestException(HttpStatusCode.NotFound, ResponseMessages.DataNotFound);
            }

            getMto.Data.MaterialTakeOffDetails.Clear();

            var mto = await _context
                .Redis
                .StringSetAsync(username, JsonConvert.SerializeObject(getMto));

            if (!mto)
            {
                throw new RestException(HttpStatusCode.BadRequest, ResponseMessages.InvalidObject);
            }

            return new SuccessResponse<object>
            {
                Message = ResponseMessages.DeleteSuccessResponse,
                Data = new {}
            };
        }
    }
}
