using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Web.Models
{
    public class Cart
    {

        public  int OrderId { get; }
        public int ToTalCount { get; set; }
        public decimal TotalPrice { get; set; }

        public Cart(int orderId)
        {
            OrderId = orderId;
            ToTalCount = 0;
            TotalPrice = 0m;
        }

        //public  IDictionary<int, int> Items { get; set; } = new Dictionary<int, int>();
        //public  decimal Amount { get; set;}

    }
}
