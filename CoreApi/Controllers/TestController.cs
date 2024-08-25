using CoreApi.Persistence.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QMS_API.Application.Core;
using QMS_API.Errors;

namespace CoreApi.Controllers
{
    
    public class TestController : BaseApiController
    {
        private readonly TestService _testService;

        public TestController(TestService testService)
        {
            _testService= testService;  
        }

        [HttpGet("get-all-employees")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetPagedEmployees([FromQuery] PagingParams pagingParams)
        {
            var results = await _testService.GetPagedEmployeesAsync(pagingParams);

            return HandlePagedResult(results);
        }


        [HttpGet("get-all-employees-without-paged")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetAllEmployees()
        {
            var results = await _testService.GetAllEmployeesAsync();

            return HandleResult(results);
        }
    }
}
