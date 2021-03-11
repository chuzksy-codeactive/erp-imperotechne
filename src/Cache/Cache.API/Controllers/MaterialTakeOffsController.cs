using AutoMapper;
using Cache.API.Entities;
using Cache.API.Helpers;
using Cache.API.Model;
using Cache.API.Repositories.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
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
        private readonly IMapper _mapper;

        public MaterialTakeOffsController(ILogger<MaterialTakeOffsController> logger, 
            IMtoRepository mtoRepository, 
            IMapper mapper)
        {
            _logger = logger;
            _mtoRepository = mtoRepository;
            _mapper = mapper;
        }

        [HttpGet("[action]")]
        [ProducesResponseType(typeof(SuccessResponse<MaterialTakeOff>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetMTO(string username)
        {
            var result = await _mtoRepository.GetMaterialTakeOffs(username);

            return Ok(result);
        }

        [HttpGet("[action]")]
        [ProducesResponseType(typeof(SuccessResponse<IEnumerable<MaterialTakeOffDetail>>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetMTODetails(string username)
        {
            var result = await _mtoRepository.GetMTODetails(username);

            return Ok(result);
        }

        [HttpPost("[action]")]
        [ProducesResponseType(typeof(SuccessResponse<object>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> CreateMTO(string username, MaterialTakeOffDto materialTakeOff)
        {
            var mto = _mapper.Map<MaterialTakeOff>(materialTakeOff);

            var result = await _mtoRepository.CreateMTO(username, mto);

            return Ok(result);
        }

        [HttpPost("[action]")]
        [ProducesResponseType(typeof(SuccessResponse<object>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> AddSingleMTODetail(string username, MaterialTakeOffDetailDto materialTakeOffDetail)
        {
            var mtoDetail = _mapper.Map<MaterialTakeOffDetail>(materialTakeOffDetail);

            var result = await _mtoRepository.AddSingleMTODetails(username, mtoDetail);

            return Ok(result);
        }

        [HttpPost("[action]")]
        [ProducesResponseType(typeof(SuccessResponse<object>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> AddMultipleMTODetails(string username, ICollection<MaterialTakeOffDetailDto> materialTakeOffDetails)
        {
            var mtoDetails = _mapper.Map<ICollection<MaterialTakeOffDetail>>(materialTakeOffDetails);

            var result = await _mtoRepository.AddMultipleMTODetails(username, mtoDetails);

            return Ok(result);
        }

        [HttpPut("[action]")]
        [ProducesResponseType(typeof(SuccessResponse<object>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> UpdateMTO(string username, MaterialTakeOffDto materialTakeOff)
        {
            var mto = _mapper.Map<MaterialTakeOff>(materialTakeOff);

            var result = await _mtoRepository.UpdateMTO(username, mto);

            return Ok(result);
        }

        [HttpPut("[action]")]
        [ProducesResponseType(typeof(SuccessResponse<object>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> UpdateMTODetails(string username, ICollection<MaterialTakeOffDetailDto> mtoDetail)
        {
            var mtoDetails = _mapper.Map<ICollection<MaterialTakeOffDetail>>(mtoDetail);

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
    }
}
