using AutoMapper;
using JPSAGE_ERP.Application.Helpers;
using JPSAGE_ERP.Application.Interfaces;
using JPSAGE_ERP.Application.Models;
using JPSAGE_ERP.Application.Models.Responses;
using JPSAGE_ERP.Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Threading.Tasks;

namespace JPSAGE_ERP.WebAPI.Controllers
{
    [Route("api/v1/materialtakeoffs")]
    [ApiController]
    [Authorize]
    public class MaterialTakeOffsController : ControllerBase
    {
        private readonly IMtoRepository _mtoRepository;
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        public MaterialTakeOffsController(IMtoRepository mtoRepository, ApplicationDbContext context, IMapper mapper)
        {
            _mtoRepository = mtoRepository;
            _context = context;
            _mapper = mapper;
        }

        [HttpGet("disciplines")]
        [ProducesResponseType(typeof(SucessResponse<IEnumerable<MtoDisciplineDto>>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetAllMtoDiscipline()
        {
            var result = await _mtoRepository.GetMtoDiscipline();

            return Ok(new SucessResponse<IEnumerable<MtoDisciplineDto>>
            {
                success = true,
                message = "Mto disciplines are successfully retrieved",
                data = result
            });
        }

        [HttpGet("subdiscipline/disciplineId")]
        [ProducesResponseType(typeof(SucessResponse<IEnumerable<MtoSubdisciplineDto>>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetSubDisciplines(int disciplineId)
        {
            var result = await _mtoRepository.GetMtosubDisciplines(disciplineId);

            return Ok(new SucessResponse<IEnumerable<MtoSubdisciplineDto>>
            {
                success = true,
                message = "Mto subdisciplines are successfully retrieved",
                data = result
            });
        }

        [HttpGet(Name = "GetMtoList")]
        public async Task<IActionResult> GetMtoList([FromQuery] MtoParameters parameters)
        {
            var userId = GetUserId();
            var tblStaff = await _context.TblStaffBioData.FirstOrDefaultAsync(x => x.AspnetUserId == userId);

            var mtoList = await _mtoRepository.GetAllMaterialTakeOffs(tblStaff.StaffId, parameters);

            var prevLink = mtoList.HasPrevious ? CreateResourceUri(parameters, ResourceUriType.PreviousPage) : null;
            var nextLink = mtoList.HasNext ? CreateResourceUri(parameters, ResourceUriType.NextPage) : null;
            var currentLink = CreateResourceUri(parameters, ResourceUriType.CurrentPage);

            var pagination = new Pagination
            {
                currentPage = currentLink,
                nextPage = nextLink,
                previousPage = prevLink,
                totalPages = mtoList.TotalPages,
                perPage = mtoList.PageSize,
                totalEntries = mtoList.TotalCount
            };

            var mtoListDto = _mapper.Map<IEnumerable<MtoDto>>(mtoList);

            return Ok(new PagedResponse<IEnumerable<MtoDto>>
            {
                success = true,
                message = "MTO retrieved successfully",
                data = mtoListDto,
                meta = new Meta
                {
                    pagination = pagination
                }
            });
        }

        [HttpGet("details")]
        public async Task<IActionResult> GetMtoDetails(int mtoId)
        {
            var mto = await _context.TblMtoformsTemp.FindAsync(mtoId);

            if (mto == null)
            {
                return NotFound(new ErrorResponse<object>
                {
                    success = false,
                    message = $"MTO with Id: {mtoId} is not found",
                    errors = new { }
                });
            }

            var result = await _mtoRepository.GetMaterialTakeOff(mtoId);

            return Ok(new SucessResponse<object>
            {
                success = true,
                message = "MTO details retrieved successfully",
                data = result
            });
        }

        #region CreateResource
        private string CreateResourceUri(MtoParameters parameters, ResourceUriType type)
        {
            switch (type)
            {
                case ResourceUriType.PreviousPage:
                    return Url.Link("GetMtoList",
                        new
                        {
                            PageNumber = parameters.PageNumber - 1,
                            parameters.PageSize,
                            parameters.ThisWeek,
                            parameters.ThisMonth,
                            parameters.LastMonth,
                            parameters.ThisYear,
                            parameters.Search,
                            parameters.DisciplineId
                        });

                case ResourceUriType.NextPage:
                    return Url.Link("GetMtoList",
                        new
                        {
                            PageNumber = parameters.PageNumber + 1,
                            parameters.PageSize,
                            parameters.ThisWeek,
                            parameters.ThisMonth,
                            parameters.LastMonth,
                            parameters.ThisYear,
                            parameters.Search,
                            parameters.DisciplineId
                        });

                default:
                    return Url.Link("GetMtoList",
                        new
                        {
                            parameters.PageNumber,
                            parameters.PageSize,
                            parameters.ThisWeek,
                            parameters.ThisMonth,
                            parameters.LastMonth,
                            parameters.ThisYear,
                            parameters.Search,
                            parameters.DisciplineId
                        });
            }

        }
        #endregion

        /// <summary>
        /// This method returns the user Id
        /// </summary>
        /// <returns name="string">string</returns>
        #region Helpers
        [NonAction]
        public string GetUserId()
        {
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var claim = claimsIdentity.Claims.Skip(1).FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier);


            var userId = claim.Value;
            return userId;
        }
        #endregion
    }
}
