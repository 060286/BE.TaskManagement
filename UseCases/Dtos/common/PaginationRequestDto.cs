using Microsoft.AspNetCore.Mvc;

namespace BE.TaskManagement.UseCases.Dtos.common
{
    public class PaginationRequestDto
    {
        [FromQuery(Name = "pageIndex")]
        public int PageIndex { get; set; }

        [FromQuery(Name = "pageSize")]
        public int PageSize { get; set; }
    }
}
