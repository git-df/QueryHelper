using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryHelper.Requests
{
    /// <summary>
    /// Pagination and sorting options
    /// </summary>
    public class RequestQueryHelper
    {
        public Pagination? Pagination { get; set; }
        public Sortting? Sortting { get; set; }
    }
}
