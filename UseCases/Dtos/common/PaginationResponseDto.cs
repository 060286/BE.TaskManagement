namespace BE.TaskManagement.UseCases.Dtos.common
{
    public class PaginationResponseDto<TData>
    {
        public int TotalCount { get; set; }

        public int TotalPages { get; set; }

        public int CurrentPage { get; set; }

        public int PageSize { get; set; }

        public IList<TData> Items { get; set; }

        public bool HasPreviousPage { get; set; }

        public bool HasNextPage { get; set; }
    }
}
