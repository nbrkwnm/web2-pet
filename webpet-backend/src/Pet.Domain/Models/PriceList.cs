using System;
using System.Collections.Generic;
using System.Text;

namespace Pet.Domain.Models
{
    public class PriceList : BaseAuditEntity
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public IList<PriceListItem> Items { get; set; }

        public PriceList()
        {
            Items = new List<PriceListItem>();
        }
    }
}
