namespace Pet.Domain.Models
{
    public class License : BaseAuditEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal NumberServices { get; set; }
        public decimal NumberOrders { get; set; }

        public License()
        { }
    }
}