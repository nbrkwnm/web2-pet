namespace Pet.Domain.Models
{
    public class Ambient : BaseAuditEntity
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool IsOccupied { get; set; }

        public Ambient()
        { }
    }
}