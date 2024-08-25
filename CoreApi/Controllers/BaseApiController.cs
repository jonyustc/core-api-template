using CoreApi.Application.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QMS_API.Application.Core;

namespace CoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseApiController : ControllerBase
    {
        protected ActionResult HandleResult<T>(Result<T> result)
        {
            if (result == null) return NotFound();

            if (result.IsSuccess && result.Value != null)
                return Ok(result);

            if (result.IsSuccess && result.Value == null)
                return NotFound();

            return BadRequest(result);
        }

        protected ActionResult HandlePagedResult<T>(Result<PagedList<T>> result)
        {
            if (result == null) return NotFound();
            if (result.IsSuccess && result.Value != null)
            {
                Response.AddPaginationHeader(result.Value.CurrentPage, result.Value.PageSize,
                    result.Value.TotalCount, result.Value.TotalPages);

                result.Pagination = new Pagination
                (
                    result.Value.CurrentPage,
                    result.Value.PageSize,
                    result.Value.TotalCount,
                    result.Value.TotalPages
                );

                result.Message = GetPageInfo(result.Value.CurrentPage, result.Value.PageSize,
                    result.Value.TotalCount, result.Value.TotalPages);

                return Ok(result);
            }

            if (result.IsSuccess && result.Value == null)
                return NotFound();
            return BadRequest(result);
        }

        private string GetPageInfo(int pageNumber, int pageSize, int totalCount, int totalPages)
        {
            var from = (pageNumber - 1) * pageSize + 1;
            var to = (pageNumber * pageSize) > totalCount ?
                totalCount : (pageNumber * pageSize);

            if (totalCount <= 0)
                return "No Data Found";
            else
                return "Showing " + from + " - " + to + " of " + totalCount + " Results";
        }
    }
}
