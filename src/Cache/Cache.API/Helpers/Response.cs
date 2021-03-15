namespace Cache.API.Helpers
{
    public class Response
    {
        public bool Success { get; set; }
        public string Message { get; set; }
    }
    public class SuccessResponse<T> : Response
    {
        public SuccessResponse()
        {
            Success = true;
        }
        public T Data { get; set; }
    }
    public class ErrorResponse<T> : Response
    {
        public T Error { get; set; }
    }

    public class Pagination
    {
        public string currentPage { get; set; }
        public string nextPage { get; set; }
        public string previousPage { get; set; }
        public int totalPages { get; set; }
        public int perPage { get; set; }
        public int totalEntries { get; set; }
    }

    public class Meta
    {
        public Pagination pagination { get; set; }
    }

    public class PagedResponse<T>
    {
        public bool success { get; set; }
        public string message { get; set; }
        public T data { get; set; }
        public Meta meta { get; set; }
    }
}
