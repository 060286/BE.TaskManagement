using BE.TaskManagement.Infrastructures.Persistence.Repository;
using BE.TaskManagement.UseCases.Dtos.v1.HomePageDto;
using BE.TaskManagement.UseCases.Services.v1.Interface;
using Microsoft.EntityFrameworkCore;

namespace BE.TaskManagement.UseCases.Services.v1
{
    public class HomePageService : IHomePageService
    {
        #region Constructors

        private readonly IRepository<Domains.Entities.Task> _taskRepository;

        public HomePageService(IRepository<Domains.Entities.Task> taskRepository)
        {
            _taskRepository = taskRepository;
        }

        #endregion

        #region Implement Method

        public CreateTaskCategoryResponseDto CreateTaskRequest(CreateTaskCategoryRequestDto request)
        {
            throw new NotImplementedException();
        }

        public async Task<List<GetTaskItemResponseDto>> GetTaskItemListRequest()
        {
            var result = new List<GetTaskItemResponseDto>();

            result = await _taskRepository.GetAll(true)
                        .Select(t => new GetTaskItemResponseDto
                        {
                            Description = t.Description,
                            Name = t.Name,
                            Id = t.Id,
                        }).ToListAsync();

            return result;
        }

        #endregion
    }
}
