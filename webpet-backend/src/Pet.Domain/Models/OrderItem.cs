namespace Pet.Domain.Models
{
    public class OrderItem : BaseEntity
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        public int ServideId { get; set; }
        public virtual Service Service { get; set; }
        public int PriceListId { get; set; }
        public virtual PriceList PriceList { get; set; }
        public decimal Quantity { get; set; }
        public decimal SoldPrice { get; set; }
        public int OrderId { get; set; }
        public virtual Order Order { get; set; }

        public OrderItem()
        { }

        // public OrderItem(Product product, PriceList priceList, decimal quantity, decimal soldPrice)
        // { }

        // public OrderItem(Service service, PriceList priceList, decimal quantity, decimal soldPrice)
        // { }
    }
}