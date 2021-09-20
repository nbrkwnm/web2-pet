using System;
using System.Collections.Generic;
using System.Text;

namespace Pet.Domain.Models
{
    public class Product : BaseAuditEntity
    {
        public string Name { get; set; }
        public string BarCode { get; set; }
        public decimal UnitCost { get; set; }

        public Product()
        { }
    }
}
