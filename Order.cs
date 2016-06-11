using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrdersSystem
{
    public class Order
    {
        public Guid Id { get; set; }
        public decimal Total { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public OrderStatus Status { get; set; }
        public List<Item> Items { get; set; }

    }
}
