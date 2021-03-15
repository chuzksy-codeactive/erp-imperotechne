using AutoMapper;
using Cache.API.Data.Interface;
using Cache.API.Entities;
using Cache.API.Enums;
using Cache.API.Helpers;
using Cache.API.Model;
using Cache.API.Repositories.Interface;
using ERP.EventBus.Common;
using ERP.EventBus.Events;
using ERP.EventBus.Producer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace Cache.API.Controllers
{
    [Route("api/mto")]
    [ApiController]
    public class MaterialTakeOffsController : ControllerBase
    {
        private readonly ILogger<MaterialTakeOffsController> _logger;
        private readonly IMtoRepository _mtoRepository;
        private readonly MTOEventProducer _mtoProducer;
        private readonly IMapper _mapper;
        private readonly ICacheContext _context;

        public MaterialTakeOffsController(ILogger<MaterialTakeOffsController> logger,
            IMtoRepository mtoRepository,
            IMapper mapper, MTOEventProducer mtoProducer, ICacheContext context)
        {
            _logger = logger;
            _mtoRepository = mtoRepository;
            _mapper = mapper;
            _mtoProducer = mtoProducer;
            _context = context;
        }

        [HttpGet("[action]")]
        [ProducesResponseType(typeof(SuccessResponse<MaterialTakeOff>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetMTO(string username)
        {
            if (string.IsNullOrEmpty(username))
            {
                return BadRequest(new ErrorResponse<object>
                {
                    Success = false,
                    Message = ResponseMessages.InvalidUsername
                });
            }

            var result = await _mtoRepository.GetMaterialTakeOffs(username);

            return Ok(result);
        }

        [HttpGet("[action]", Name = "GetDetails")]
        [ProducesResponseType(typeof(SuccessResponse<IEnumerable<object>>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetMTODetails(string username, [FromQuery] ResourceParameters parameters)
        {
            if (string.IsNullOrEmpty(username))
            {
                return BadRequest(new ErrorResponse<object>
                {
                    Success = false,
                    Message = ResponseMessages.InvalidUsername
                });
            }

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
                var civilList = PagedList<MtoCivilDetailsDto>.Create(mtoDto.MtoCivilDetails, parameters.PageNumber, parameters.PageSize);

                var prevLink = civilList.HasPrevious ? CreateResourceUri(parameters, ResourceUriType.PreviousPage) : null;
                var nextLink = civilList.HasNext ? CreateResourceUri(parameters, ResourceUriType.NextPage) : null;
                var currentLink = CreateResourceUri(parameters, ResourceUriType.CurrentPage);

                var pagination = new Pagination
                {
                    currentPage = currentLink,
                    nextPage = nextLink,
                    previousPage = prevLink,
                    totalPages = civilList.TotalPages,
                    perPage = civilList.PageSize,
                    totalEntries = civilList.TotalCount
                };

                return Ok(new PagedResponse<IEnumerable<MtoCivilDetailsDto>>
                {
                    success = true,
                    message = "MTO items retrieved successfully",
                    data = civilList,
                    meta = new Meta
                    {
                        pagination = pagination
                    }
                });
            }

            if (result.DisciplineId == (int)EMtoDiscipline.Electrical)
            {
                var electricalList = PagedList<MtoElectricalDetailsDto>.Create(mtoDto.MtoElectricalDetails, parameters.PageNumber, parameters.PageSize);

                var prevLink = electricalList.HasPrevious ? CreateResourceUri(parameters, ResourceUriType.PreviousPage) : null;
                var nextLink = electricalList.HasNext ? CreateResourceUri(parameters, ResourceUriType.NextPage) : null;
                var currentLink = CreateResourceUri(parameters, ResourceUriType.CurrentPage);

                var pagination = new Pagination
                {
                    currentPage = currentLink,
                    nextPage = nextLink,
                    previousPage = prevLink,
                    totalPages = electricalList.TotalPages,
                    perPage = electricalList.PageSize,
                    totalEntries = electricalList.TotalCount
                };

                return Ok(new PagedResponse<IEnumerable<MtoElectricalDetailsDto>>
                {
                    success = true,
                    message = "MTO items retrieved successfully",
                    data = electricalList,
                    meta = new Meta
                    {
                        pagination = pagination
                    }
                });
            }

            if (result.DisciplineId == (int)EMtoDiscipline.Piping)
            {
                var pipingList = PagedList<MtoPipingDetailsDto>.Create(mtoDto.MtoPipingDetails, parameters.PageNumber, parameters.PageSize);

                var prevLink = pipingList.HasPrevious ? CreateResourceUri(parameters, ResourceUriType.PreviousPage) : null;
                var nextLink = pipingList.HasNext ? CreateResourceUri(parameters, ResourceUriType.NextPage) : null;
                var currentLink = CreateResourceUri(parameters, ResourceUriType.CurrentPage);

                var pagination = new Pagination
                {
                    currentPage = currentLink,
                    nextPage = nextLink,
                    previousPage = prevLink,
                    totalPages = pipingList.TotalPages,
                    perPage = pipingList.PageSize,
                    totalEntries = pipingList.TotalCount
                };

                return Ok(new PagedResponse<IEnumerable<MtoPipingDetailsDto>>
                {
                    success = true,
                    message = "Mto items retrieved successfully",
                    data = pipingList,
                    meta = new Meta
                    {
                        pagination = pagination
                    }
                });
            }

            var instrumentList = PagedList<MtoInstrumentDetailsDto>.Create(mtoDto.MtoInstrumentDetails, parameters.PageNumber, parameters.PageSize);

            var prev = instrumentList.HasPrevious ? CreateResourceUri(parameters, ResourceUriType.PreviousPage) : null;
            var next = instrumentList.HasNext ? CreateResourceUri(parameters, ResourceUriType.NextPage) : null;
            var current = CreateResourceUri(parameters, ResourceUriType.CurrentPage);

            var page = new Pagination
            {
                currentPage = current,
                nextPage = next,
                previousPage = prev,
                totalPages = instrumentList.TotalPages,
                perPage = instrumentList.PageSize,
                totalEntries = instrumentList.TotalCount
            };

            return Ok(new PagedResponse<IEnumerable<MtoInstrumentDetailsDto>>
            {
                success = true,
                message = "MTO items retrieved successfully",
                data = instrumentList,
                meta = new Meta
                {
                    pagination = page
                }
            });
        }

        [HttpPost("[action]")]
        [ProducesResponseType(typeof(SuccessResponse<object>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> CreateMTO(MaterialTakeOffDto mto)
        {
            var result = await _mtoRepository.CreateMTO(mto.UserEmail, mto);

            return Ok(result);
        }

        [HttpPost("[action]")]
        [ProducesResponseType(typeof(SuccessResponse<object>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> AddSingleMTODetail(string username, MtoDisciplineDetailDto materialTakeOffDetail)
        {
            if (string.IsNullOrEmpty(username))
            {
                return BadRequest(new ErrorResponse<object>
                {
                    Success = false,
                    Message = ResponseMessages.InvalidUsername
                });
            }

            var result = await _mtoRepository.AddSingleMTODetails(username, materialTakeOffDetail);

            return Ok(result);
        }

        [HttpPost("[action]")]
        [ProducesResponseType(typeof(SuccessResponse<object>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> AddMultipleMTODetails(string username, MtoDisciplineDetailsDto materialTakeOffDetails)
        {
            if (string.IsNullOrEmpty(username))
            {
                return BadRequest(new ErrorResponse<object>
                {
                    Success = false,
                    Message = ResponseMessages.InvalidUsername
                });
            }

            var result = await _mtoRepository.AddMultipleMTODetails(username, materialTakeOffDetails);

            return Ok(result);
        }

        [HttpPut("[action]")]
        [ProducesResponseType(typeof(SuccessResponse<object>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> UpdateMTO(MaterialTakeOffDto mto)
        {
            var result = await _mtoRepository.UpdateMTO(mto.UserEmail, mto);

            return Ok(result);
        }

        [HttpPut("[action]")]
        [ProducesResponseType(typeof(SuccessResponse<object>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> UpdateMTODetails(string username, MtoDisciplineDetailsDto mtoDetails)
        {
            var result = await _mtoRepository.UpdateMTODetails(username, mtoDetails);

            return Ok(result);
        }

        [HttpDelete("[action]")]
        [ProducesResponseType(typeof(SuccessResponse<object>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> DeleteMTO(string username)
        {
            var result = await _mtoRepository.DeleteMTO(username);

            return Ok(result);
        }

        [HttpDelete("[action]")]
        [ProducesResponseType(typeof(SuccessResponse<object>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> ClearMTODetails(string username)
        {
            var result = await _mtoRepository.ClearMTODetails(username);

            return Ok(result);
        }

        [HttpDelete("details/{itemId}")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<IActionResult> RemoveMtoItem(string username, Guid itemId)
        {
            var result = await _mtoRepository.RemoveMTOItem(username, itemId);

            return Ok(result);
        }


        [HttpPost("submit")]
        [ProducesResponseType((int)HttpStatusCode.Accepted)]
        public async Task<IActionResult> SubmitMtoForm(string username)
        {
            var mto = await _mtoRepository.GetMaterialTakeOffs(username);

            await _mtoRepository.DeleteMTO(username);

            var mtoDto = mto.Data;
            var mtoMessage = _mapper.Map<MaterialTakeOffEvent>(mtoDto);
            mtoMessage.RequestId = Guid.NewGuid();

            if (mtoDto.DisciplineId == (int)EMtoDiscipline.Civil)
            {
                var result = _mapper.Map<ICollection<MtoCivilDetailsEvent>>(mtoDto.MtoCivilDetails);
                mtoMessage.MtoCivilDetailsEvents = result;
            }

            if (mtoDto.DisciplineId == (int)EMtoDiscipline.Electrical)
            {
                var result = _mapper.Map<ICollection<MtoElectricalDetailsEvent>>(mtoDto.MtoElectricalDetails);
                mtoMessage.MtoElectricalDetailsEvents = result;
            }

            if (mtoDto.DisciplineId == (int)EMtoDiscipline.Piping)
            {
                var result = _mapper.Map<ICollection<MtoPipingDetailsEvent>>(mtoDto.MtoPipingDetails);
                mtoMessage.MtoPipingDetailsEvents = result;
            }

            if (mtoDto.DisciplineId == (int)EMtoDiscipline.Instrument)
            {
                var result = _mapper.Map<ICollection<MtoInstrumentDetailsEvent>>(mtoDto.MtoInstrumentDetails);
                mtoMessage.MtoInstrumentDetailsEvents = result;
            }

            try
            {
                _mtoProducer.PublishMTOEvent(EventBusConstants.MtoQueue, mtoMessage);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "ERROR Publishing integration event: {EventId} from {AppName}", mtoMessage.RequestId, "MaterialTakeOff");
                throw;
            }

            return Accepted(new SuccessResponse<object>
            {
                Success = true,
                Message = ResponseMessages.SubmitSuccessResponse,
                Data = new { }
            });
        }

        #region CreateResource
        private string CreateResourceUri(ResourceParameters parameters, ResourceUriType type)
        {
            switch (type)
            {
                case ResourceUriType.PreviousPage:
                    return Url.Link("GetDetails",
                        new
                        {
                            PageNumber = parameters.PageNumber - 1,
                            parameters.PageSize,
                        });

                case ResourceUriType.NextPage:
                    return Url.Link("GetDetails",
                        new
                        {
                            PageNumber = parameters.PageNumber + 1,
                            parameters.PageSize,
                        });

                default:
                    return Url.Link("GetDetails",
                        new
                        {
                            parameters.PageNumber,
                            parameters.PageSize,
                        });
            }

        }
        #endregion
    }
}
