using System;
using System.Collections.Generic;
using System.Text;
using Pet.Domain.Enum;

namespace Pet.Domain.Models
{
    public class Order : BaseAuditEntity
    {
        public string OrderNumber { get; set; }
        public OrderStatusType Status { get; set; }
        public Payment Payment { get; set; }
        public IList<OrderItem> Items { get; set; }

        public Order()
        {
            Items = new List<OrderItem>();
        }
    }
}
