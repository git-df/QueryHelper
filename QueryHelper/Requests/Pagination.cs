namespace QueryHelper.Requests
{
    public class Pagination
    {
        public int PageIndex { get; set; } = 1;
        public int PageSize { get; set; } = 10;

        public PaginationResponse? Add<T>(ref IQueryable<T> query)
        {
            if (PageIndex < 1 && PageSize < 1)
                return null;

            var count = query.Count();

            query = query
                .Skip(PageSize * (PageIndex - 1))
                .Take(PageSize);

            return new PaginationResponse
            {
                TotalCount = count,
                TotalPages = (int)Math.Ceiling((double)count / PageSize),
                FirstIndex = count == 0 ? 0 : PageSize * (PageIndex - 1) + 1,
                LastIndex = Math.Min(PageSize * PageIndex, count)
            };
        }
    }
}
