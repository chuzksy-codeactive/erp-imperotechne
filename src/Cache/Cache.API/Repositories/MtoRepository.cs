using AutoMapper;
using Cache.API.Data.Interface;
using Cache.API.Entities;
using Cache.API.Enums;
using Cache.API.Helpers;
using Cache.API.Model;
using Cache.API.Repositories.Interface;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public async Task<SuccessResponse<IEnumerable<object>>> GetMTODetails(string username)
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

            if (result.DisciplineId == (int)EMtoDiscipline.Civil)
            {
                return new SuccessResponse<IEnumerable<object>>
                {
                    Message = ResponseMessages.RetrievalSuccessResponse,
                    Data = mtoDto.MtoCivilDetails
                };
            }

            if (result.DisciplineId == (int)EMtoDiscipline.Electrical)
            {
                return new SuccessResponse<IEnumerable<object>>
                {
                    Message = ResponseMessages.RetrievalSuccessResponse,
                    Data = mtoDto.MtoElectricalDetails
                };
            }

            if (result.DisciplineId == (int)EMtoDiscipline.Piping)
            {
                return new SuccessResponse<IEnumerable<object>>
                {
                    Message = ResponseMessages.RetrievalSuccessResponse,
                    Data = mtoDto.MtoPipingDetails
                };
            }

            return new SuccessResponse<IEnumerable<object>>
            {
                Message = ResponseMessages.RetrievalSuccessResponse,
                Data = mtoDto.MtoInstrumentDetails
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

        public async Task<SuccessResponse<object>> CreateMTO(string username, MaterialTakeOffDto materialTakeOff)
        {
            if (!Enum.IsDefined(typeof(EMtoDiscipline), materialTakeOff.DisciplineId))
            {
                throw new RestException(HttpStatusCode.BadRequest, ResponseMessages.DisciplineNotDefined);
            }

            var mtoEntity = new MaterialTakeOff
            {
                UserEmail = materialTakeOff.UserEmail,
                ProjectId = materialTakeOff.ProjectId,
                CompanyId = materialTakeOff.CompanyId,
                DisciplineId = materialTakeOff.DisciplineId,
                SubDisciplineId = materialTakeOff.SubDisciplineId,
                ClientId = materialTakeOff.ClientId,
                Title = materialTakeOff.Title,
                ValidityStatus = materialTakeOff.ValidityStatus,
                ValidityPeriod = materialTakeOff.ValidityPeriod,
                CreatedBy = materialTakeOff.UserEmail
            };

            if (materialTakeOff.DisciplineId == (int)EMtoDiscipline.Civil)
            {
                var civils = _mapper.Map<ICollection<MtoCivilDetails>>(materialTakeOff.MtoCivilDetails);
                mtoEntity.MtoCivilDetails = civils;

            }
            else if (materialTakeOff.DisciplineId == (int)EMtoDiscipline.Electrical)
            {
                var electrical = _mapper.Map<ICollection<MtoElectricalDetails>>(materialTakeOff.MtoElectricalDetails);
                mtoEntity.MtoElectricalDetails = electrical;
            }
            else if (materialTakeOff.DisciplineId == (int)EMtoDiscipline.Instrument)
            {
                var instruments = _mapper.Map<ICollection<MtoInstrumentDetails>>(materialTakeOff.MtoInstrumentDetails);
                mtoEntity.MtoInstrumentDetails = instruments;
            }
            else
            {
                var pipings = _mapper.Map<ICollection<MtoPipingDetails>>(materialTakeOff.MtoPipingDetails);
                mtoEntity.MtoPipingDetails = pipings;
            }

            var mto = await _context
                .Redis
                .StringSetAsync(username, JsonConvert.SerializeObject(mtoEntity));

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

        public async Task<SuccessResponse<object>> AddSingleMTODetails(string username, MtoDisciplineDetailDto mtoDisciplineDto)
        {
            var getMtoDto = await GetMaterialTakeOffs(username);

            if (getMtoDto == null)
            {
                throw new RestException(HttpStatusCode.NotFound, ResponseMessages.DataNotFound);
            }

            var getMto = _mapper.Map<MaterialTakeOff>(getMtoDto.Data);

            if (getMto.DisciplineId == (int)EMtoDiscipline.Civil)
            {
                var civil = _mapper.Map<MtoCivilDetails>(mtoDisciplineDto.MtoCivilDetail);
                getMto.MtoCivilDetails.Add(civil);
            }
            else if (getMto.DisciplineId == (int)EMtoDiscipline.Electrical)
            {
                var electrical = _mapper.Map<MtoElectricalDetails>(mtoDisciplineDto.MtoElectricalDetail);
                getMto.MtoElectricalDetails.Add(electrical);
            }
            else if (getMto.DisciplineId == (int)EMtoDiscipline.Instrument)
            {
                var instrument = _mapper.Map<MtoInstrumentDetails>(mtoDisciplineDto.MtoInstrumentDetail);
                getMto.MtoInstrumentDetails.Add(instrument);
            }
            else
            {
                var piping = _mapper.Map<MtoPipingDetails>(mtoDisciplineDto.MtoPipingDetail);
                getMto.MtoPipingDetails.Add(piping);
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
                Message = ResponseMessages.ItemAddedSuccessResponse,
                Data = new {}
            };
        }

        public async Task<SuccessResponse<object>> AddMultipleMTODetails(string username, MtoDisciplineDetailsDto mtoDetails)
        {
            var getMtoDto = await GetMaterialTakeOffs(username);

            if (getMtoDto == null)
            {
                throw new RestException(HttpStatusCode.NotFound, ResponseMessages.DataNotFound);
            }

            var getMto = _mapper.Map<MaterialTakeOff>(getMtoDto.Data);

            if (getMto.DisciplineId == (int)EMtoDiscipline.Civil)
            {
                var civils = _mapper.Map<ICollection<MtoCivilDetails>>(mtoDetails.MtoCivilDetails);
                
                foreach (var mtoDetail in civils)
                {
                    getMto.MtoCivilDetails.Add(mtoDetail);
                }
            }
            else if (getMto.DisciplineId == (int)EMtoDiscipline.Electrical)
            {
                var electrical = _mapper.Map<ICollection<MtoElectricalDetails>>(mtoDetails.MtoElectricalDetails);
                
                foreach (var mtoDetail in electrical)
                {
                    getMto.MtoElectricalDetails.Add(mtoDetail);
                }
            }
            else if (getMto.DisciplineId == (int)EMtoDiscipline.Piping)
            {
                var piping = _mapper.Map<ICollection<MtoPipingDetails>>(mtoDetails.MtoPipingDetails);

                foreach (var mtoDetail in piping)
                {
                    getMto.MtoPipingDetails.Add(mtoDetail);
                }
            }
            else
            {
                var instrument = _mapper.Map<ICollection<MtoInstrumentDetails>>(mtoDetails.MtoInstrumentDetails);

                foreach (var mtoDetail in instrument)
                {
                    getMto.MtoInstrumentDetails.Add(mtoDetail);
                }
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

        public async Task<SuccessResponse<object>> UpdateMTO(string username, MaterialTakeOffDto materialTakeOff)
        {
            var getMtoDto = await GetMaterialTakeOffs(username);

            if (getMtoDto == null)
            {
                throw new RestException(HttpStatusCode.NotFound, ResponseMessages.DataNotFound);
            }

            if (!Enum.IsDefined(typeof(EMtoDiscipline), materialTakeOff.DisciplineId))
            {
                throw new RestException(HttpStatusCode.BadRequest, ResponseMessages.DisciplineNotDefined);
            }

            var mtoEntity = new MaterialTakeOff
            {
                UserEmail = materialTakeOff.UserEmail,
                ProjectId = materialTakeOff.ProjectId,
                CompanyId = materialTakeOff.CompanyId,
                DisciplineId = materialTakeOff.DisciplineId,
                SubDisciplineId = materialTakeOff.SubDisciplineId,
                ClientId = materialTakeOff.ClientId,
                Title = materialTakeOff.Title,
                ValidityPeriod = materialTakeOff.ValidityPeriod,
                CreatedBy = materialTakeOff.UserEmail
            };

            if (materialTakeOff.DisciplineId == (int)EMtoDiscipline.Civil)
            {
                var civils = _mapper.Map<ICollection<MtoCivilDetails>>(materialTakeOff.MtoCivilDetails);
                mtoEntity.MtoCivilDetails = civils;

            }
            else if (materialTakeOff.DisciplineId == (int)EMtoDiscipline.Electrical)
            {
                var electrical = _mapper.Map<ICollection<MtoElectricalDetails>>(materialTakeOff.MtoElectricalDetails);
                mtoEntity.MtoElectricalDetails = electrical;
            }
            else if (materialTakeOff.DisciplineId == (int)EMtoDiscipline.Instrument)
            {
                var instruments = _mapper.Map<ICollection<MtoInstrumentDetails>>(materialTakeOff.MtoInstrumentDetails);
                mtoEntity.MtoInstrumentDetails = instruments;
            }
            else
            {
                var pipings = _mapper.Map<ICollection<MtoPipingDetails>>(materialTakeOff.MtoPipingDetails);
                mtoEntity.MtoPipingDetails = pipings;
            }

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

        public async Task<SuccessResponse<object>> UpdateMTODetails(string username, MtoDisciplineDetailsDto mtoDetails)
        {
            var getMtoDto = await GetMaterialTakeOffs(username);

            if (getMtoDto == null)
            {
                throw new RestException(HttpStatusCode.NotFound, ResponseMessages.DataNotFound);
            }

            var getMto = _mapper.Map<MaterialTakeOff>(getMtoDto.Data);

            if (getMto.DisciplineId == (int)EMtoDiscipline.Civil)
            {
                var civils = _mapper.Map<ICollection<MtoCivilDetails>>(mtoDetails.MtoCivilDetails);
                getMto.MtoCivilDetails = civils;
            }
            else if (getMto.DisciplineId == (int)EMtoDiscipline.Electrical)
            {
                var electricals = _mapper.Map<ICollection<MtoElectricalDetails>>(mtoDetails.MtoElectricalDetails);
                getMto.MtoElectricalDetails = electricals;
            }
            else if (getMto.DisciplineId == (int)EMtoDiscipline.Piping)
            {
                var pipings = _mapper.Map<ICollection<MtoPipingDetails>>(mtoDetails.MtoPipingDetails);
                getMto.MtoPipingDetails = pipings;
            }
            else
            {
                var instruments = _mapper.Map<ICollection<MtoInstrumentDetails>>(mtoDetails.MtoInstrumentDetails);
                getMto.MtoInstrumentDetails = instruments;
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

            getMto.Data.MtoCivilDetails.Clear();
            getMto.Data.MtoInstrumentDetails.Clear();
            getMto.Data.MtoElectricalDetails.Clear();
            getMto.Data.MtoPipingDetails.Clear();

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

        public async Task<SuccessResponse<object>> RemoveMTOItem(string username, Guid itemId)
        {
            if (string.IsNullOrEmpty(username))
            {
                throw new RestException(HttpStatusCode.BadRequest, ResponseMessages.InvalidUsername);
            }

            var getMto = await GetMaterialTakeOffs(username);

            if (getMto == null)
            {
                throw new RestException(HttpStatusCode.NotFound, ResponseMessages.DataNotFound);
            }

            var mtoEntity = _mapper.Map<MaterialTakeOff>(getMto.Data);
            var disciplineId = getMto.Data.DisciplineId;

            if (disciplineId == (int)EMtoDiscipline.Civil)
            {
                var item = getMto.Data.MtoCivilDetails.FirstOrDefault(x => x.ItemId == itemId);

                if (item == null)
                {
                    throw new RestException(HttpStatusCode.NotFound, ResponseMessages.ItemNotFound);
                }

                var rm = getMto.Data.MtoCivilDetails.Remove(item);
            }
            else if (disciplineId == (int)EMtoDiscipline.Electrical)
            {
                var item = getMto.Data.MtoElectricalDetails.FirstOrDefault(x => x.ItemId == itemId);

                if (item == null)
                {
                    throw new RestException(HttpStatusCode.NotFound, ResponseMessages.ItemNotFound);
                }

                var rm = getMto.Data.MtoElectricalDetails.Remove(item);
            }
            else if (disciplineId == (int)EMtoDiscipline.Piping)
            {
                var item = getMto.Data.MtoPipingDetails.FirstOrDefault(x => x.ItemId == itemId);

                if (item == null)
                {
                    throw new RestException(HttpStatusCode.NotFound, ResponseMessages.ItemNotFound);
                }

                var rm = getMto.Data.MtoPipingDetails.Remove(item);
            }
            else
            {
                var item = getMto.Data.MtoInstrumentDetails.FirstOrDefault(x => x.ItemId == itemId);

                if (item == null)
                {
                    throw new RestException(HttpStatusCode.NotFound, ResponseMessages.ItemNotFound);
                }

                var rm = getMto.Data.MtoInstrumentDetails.Remove(item);
            }

            var result = _mapper.Map<MaterialTakeOff>(getMto.Data);

            var mto = await _context
                .Redis
                .StringSetAsync(username, JsonConvert.SerializeObject(result));

            if (!mto)
            {
                throw new RestException(HttpStatusCode.BadRequest, ResponseMessages.InvalidObject);
            }

            return new SuccessResponse<object>
            {
                Message = ResponseMessages.RemoveSuccessResponse,
                Data = new { }
            };
        }
    }
}
