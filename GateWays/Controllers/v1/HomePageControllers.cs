using BE.TaskManagement.UseCases.Services.v1.Interface;
using Microsoft.AspNetCore.Mvc;

namespace BE.TaskManagement.GateWays.Controllers.v1
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomePageControllers : ControllerBase
    {
        private readonly IHomePageService _homePageService;

        public HomePageControllers(IHomePageService homePageService)
        {
            _homePageService = homePageService;
        }

        [HttpGet(Name = "task-list")]
        public async Task<IActionResult> GetTaskListHandler()
        {
            var response = await _homePageService.GetTaskItemListRequest();

            return Ok(response);
        }
    }
}
