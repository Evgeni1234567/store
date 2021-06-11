using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Web.Models
{
    public class Cart
    {
        public IDictionary<int, int> Intems { get; set; } = new Dictionary<int, int>();
        public decimal Amount { get; set; }
    }
}
