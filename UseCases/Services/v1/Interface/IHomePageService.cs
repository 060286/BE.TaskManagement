using BE.TaskManagement.UseCases.Dtos.v1.HomePageDto;

namespace BE.TaskManagement.UseCases.Services.v1.Interface
{
    public interface IHomePageService
    {
        CreateTaskCategoryResponseDto CreateTaskRequest(CreateTaskCategoryRequestDto request);

        Task<List<GetTaskItemResponseDto>> GetTaskItemListRequest();
    }
}
