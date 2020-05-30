using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Web.Models
{
    public class Cart
    {
        public  IDictionary<int, int> Items { get; set; } = new ConcurrentDictionary<int, int>();
        public  decimal Amount { get; set;}

    }
}
