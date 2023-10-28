namespace QueryHelper.Requests
{
    public class PaginationResponse
    {
        public int TotalCount { get; set; }
        public int TotalPages { get; set; }
        public int FirstIndex { get; set; }
        public int LastIndex { get; set; }
    }
}
