namespace BE.TaskManagement.UseCases.Dtos.v1.HomePageDto
{
    public class GetTaskItemResponseDto
    {
        public Guid Id { get; set; }

        public required string Name { get; set; }

        public required string Description { get; set; }
    }
}
