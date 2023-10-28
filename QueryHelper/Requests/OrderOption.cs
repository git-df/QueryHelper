using System.Linq.Expressions;

namespace QueryHelper.Requests
{
    public class OrderOption<T> where T : class
    {
        public string Name { get; set; }
        public Expression<Func<T, dynamic>> OorderBy { get; set; }

        public OrderOption(string name, Expression<Func<T, dynamic>> orderBy)
        {
            Name = name;
            OorderBy = orderBy;
        }
    }
}
