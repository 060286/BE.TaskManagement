using Microsoft.AspNetCore.Mvc;

namespace BE.TaskManagement.UseCases.Dtos.common
{
    public class PaginationRequestWithKeyword : PaginationRequestDto
    {
        [FromQuery(Name = "keyword")]
        public string Keyword { get; set; }
    }
}
