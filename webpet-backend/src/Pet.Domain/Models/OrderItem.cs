namespace Pet.Domain.Models
{
    public class OrderItem : BaseEntity
    {
        public Product Product { get; set; }
        public Service Service { get; set; }
        public PriceList PriceList { get; set; }
        public decimal Quantity { get; set; }
        public decimal SoldPrice { get; set; }
        
        public OrderItem(Product product, PriceList priceList, decimal quantity, decimal soldPrice)
        { }

        public OrderItem(Service service, PriceList priceList, decimal quantity, decimal soldPrice)
        { }
    }
}