using System;
using System.Collections.Generic;
using System.Text;
using Pet.Domain.Enum;

namespace Pet.Domain.Models
{
    public class Inventory : BaseAuditEntity
    {
        public int Id { get; set; }
        public virtual IList<Product> Products { get; set; }
        public InventoryStatusType Status { get; set; }

        public Inventory()
        { }
    }
}
