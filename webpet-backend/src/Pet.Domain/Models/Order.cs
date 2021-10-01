using System;
using System.Collections.Generic;
using System.Text;
using Pet.Domain.Enum;

namespace Pet.Domain.Models
{
    public class Order : BaseAuditEntity
    {
        public int Id { get; set; }
        public string OrderNumber { get; set; }
        public OrderStatusType Status { get; set; }
        public int PaymentId { get; set; }
        public virtual Payment Payment { get; set; }
        public virtual IList<OrderItem> Items { get; set; }

        public Order()
        {
            Items = new List<OrderItem>();
        }
    }
}
