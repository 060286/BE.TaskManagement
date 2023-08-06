using BE.TaskManagement.UseCases.Services.v1.Interface;
using Microsoft.AspNetCore.Mvc;

namespace BE.TaskManagement.GateWays.Controllers.v1
{
    [ApiVersion("1.0")]
    public class HomePageControllers : BaseController
    {
        private readonly IHomePageService _homePageService;

        public HomePageControllers(IHomePageService homePageService)
        {
            _homePageService = homePageService;
        }

        [HttpGet("task-list")]
        public async Task<IActionResult> GetTaskListHandler()
        {
            var response = await _homePageService.GetTaskItemListRequest();

            return Ok(response);
        }
    }
}
