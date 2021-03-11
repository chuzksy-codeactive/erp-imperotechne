using AutoMapper;
using JPSAGE_ERP.Application.Helpers;
using JPSAGE_ERP.Application.Interfaces;
using JPSAGE_ERP.Application.Models.Responses;
using JPSAGE_ERP.Application.Models.SiteReporting;
using JPSAGE_ERP.Domain;
using JPSAGE_ERP.Domain.Enums;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace JPSAGE_ERP.WebAPI.Controllers
{
    public class AuthListsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IAuthListRepository _authListRepository;
        private readonly IMapper _mapper;
        public AuthListsController(ApplicationDbContext context,
            IAuthListRepository authListRepository, IMapper mapper)
        {
            _context = context;
            _authListRepository = authListRepository;
            _mapper = mapper;
        }

        /// <summary>
        /// Endpoint to get Auth list Transaction list for Initiator, 
        /// Checker and Approver
        /// </summary>
        /// <returns></returns>
        [HttpGet("authlists", Name = "GetAuthList")]
        [ProducesResponseType(typeof(SucessResponse<PagedResponse<IEnumerable<AuthListDto>>>), 200)]
        public async Task<IActionResult> GetTransactionList([FromQuery] AuthListParameters parameters)
        {
            var userId = GetUserId();
            var tblStaff = await _context.TblStaffBioData.FirstOrDefaultAsync(x => x.AspnetUserId == userId);

            var authList = await _authListRepository.GetTransactionList(tblStaff.StaffId, parameters);

            var prevLink = authList.HasPrevious ? CreateResourceUri(parameters, ResourceUriType.PreviousPage) : null;
            var nextLink = authList.HasNext ? CreateResourceUri(parameters, ResourceUriType.NextPage) : null;
            var currentLink = CreateResourceUri(parameters, ResourceUriType.CurrentPage);

            var pagination = new Pagination
            {
                currentPage = currentLink,
                nextPage = nextLink,
                previousPage = prevLink,
                totalPages = authList.TotalPages,
                perPage = authList.PageSize,
                totalEntries = authList.TotalCount
            };

            var authListDto = _mapper.Map<IEnumerable<AuthListDto>>(authList);

            return Ok(new PagedResponse<IEnumerable<AuthListDto>>
            {
                success = true,
                message = "Departments retrieved successfully",
                data = authListDto,
                meta = new Meta
                {
                    pagination = pagination
                }
            });
        }

        /// <summary>
        /// Endpoint to get Transaction detail by Workflow definition Id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="wfDefId"></param>
        /// <returns></returns>
        [HttpGet("{id}/details")]
        public async Task<IActionResult> GetTransactionDetails(int id, EWorflowDefinition wfDefId)
        {
            if (!Enum.IsDefined(typeof(EWorflowDefinition), (int)wfDefId))
            {
                return BadRequest(new 
                {
                    success = false,
                    message = "Workflow definition Id is not define",
                    errors = new {}
                });
            }

            var authList = await _context.TblAuthList.FindAsync(id);

            if (authList == null)
            {
                return NotFound(new ErrorResponse<object>
                {
                    success = false,
                    message = $"Auth list with Id: {id} is not found",
                    errors = new { }
                });
            }

            if (wfDefId == EWorflowDefinition.GENERALSUMMARY)
            {
                var result = await _authListRepository.GetGeneralSummaryDetail(id);

                return Ok(new SucessResponse<object>
                {
                    success = true,
                    message = "General summary details retrieved successfully",
                    data = result
                });
            }

            if (wfDefId == EWorflowDefinition.HSEREPORT)
            {
                var result = await _authListRepository.GetHseDetail(id);

                return Ok(new SucessResponse<object>
                {
                    success = true,
                    message = "Hse report details retrieved successfully",
                    data = result
                });
            }

            if (wfDefId == EWorflowDefinition.OTHERSITE)
            {
                var result = await _authListRepository.GetOtherSiteDetialDetail(id);

                return Ok(new SucessResponse<object>
                {
                    success = true,
                    message = "Other site report details retrieved successfully",
                    data = result
                });
            }

            if (wfDefId == EWorflowDefinition.PROGRESSPICTURES)
            {
                var result = await _authListRepository.GetProgressPicturesDetail(id);

                return Ok(new SucessResponse<object>
                {
                    success = true,
                    message = "Progress pictures details retrieved successfully",
                    data = result
                });
            }

            if (wfDefId == EWorflowDefinition.CONSTRUCTIONACTIVITY)
            {
                var result = await _authListRepository.GetConstructionActivityDetail(id);

                return Ok(new SucessResponse<object>
                {
                    success = true,
                    message = "construction activities details retrieved successfully",
                    data = result
                });
            }

            if (wfDefId == EWorflowDefinition.CONSTRUCTIONTECHNICALQUERY)
            {
                var result = await _authListRepository.GetConstructionTechnicalDetail(id);

                return Ok(new SucessResponse<object>
                {
                    success = true,
                    message = "Construction technical query details retrieved successfully",
                    data = result
                });
            }

            if (wfDefId == EWorflowDefinition.NONCONFORMANCEREPORT)
            {
                var result = await _authListRepository.GetNonConformanceDetail(id);

                return Ok(new SucessResponse<object>
                {
                    success = true,
                    message = "Non conformance report details retrieved successfully",
                    data = result
                });
            }

            if (wfDefId == EWorflowDefinition.DAILYPGMEASUREMENT)
            {
                var result = await _authListRepository.GetDailyPGMeasurmentDetail(id);

                return Ok(new SucessResponse<object>
                {
                    success = true,
                    message = "Daily progress measurement details retrieved successfully",
                    data = result
                });
            }

            return BadRequest(new SucessResponse<object>
            {
                success = false,
                message = "Sorry! Something went wrong",
                data = new {}
            }); ;
        }

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

        #region CreateResource
        private string CreateResourceUri(ResourceParameters parameters, ResourceUriType type)
        {
            switch (type)
            {
                case ResourceUriType.PreviousPage:
                    return Url.Link("GetAuthList",
                        new
                        {
                            PageNumber = parameters.PageNumber - 1,
                            parameters.PageSize,
                        });

                case ResourceUriType.NextPage:
                    return Url.Link("GetAuthList",
                        new
                        {
                            PageNumber = parameters.PageNumber + 1,
                            parameters.PageSize,
                        });

                default:
                    return Url.Link("GetAuthList",
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
