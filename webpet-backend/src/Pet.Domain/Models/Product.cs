using System;
using System.Collections.Generic;
using System.Text;

namespace Pet.Domain.Models
{
    public class Product : BaseAuditEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string BarCode { get; set; }
        public decimal UnitCost { get; set; }
        public int InventoryId { get; set; }
        public virtual Inventory Inventory { get; set; }

        public Product()
        { }
    }
}
