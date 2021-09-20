namespace Pet.Domain.Models
{
    public class PriceListItem : BaseAuditEntity
    {
        public Product Product { get; set; }
        public decimal Value { get; set; }

        public PriceListItem()
        { }
    }
}