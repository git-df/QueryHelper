namespace QueryHelper.Requests
{
    public class Sortting
    {
        public string OrderBy { get; set; } = string.Empty;
        public bool IsDescending { get; set; } = false;

        public void Add<T>(ref IQueryable<T> query, List<OrderOption<T>> options) where T : class
        {
            if (options == null || !options.Any())
                return;

            var option = options
                .FirstOrDefault(x => x.Name.ToLower() == OrderBy.ToLower())
                ?? options.FirstOrDefault();

            if (option != null)
            {
                query = IsDescending
                    ? query.OrderByDescending(option.OorderBy)
                    : query.OrderBy(option.OorderBy);
            }
        }
    }
}
