namespace Pet.Domain.Models
{
    public class PriceListItem : BaseAuditEntity
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        public decimal Value { get; set; }
        public int PriceListId { get; set; }
        public PriceList PriceList { get; set; }

        public PriceListItem()
        { }
    }
}