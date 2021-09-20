namespace Pet.Domain.Models
{
    public class Ambient : BaseAuditEntity
    {
        public string Description { get; set; }
        public bool IsOccupied { get; set; }

        public Ambient()
        { }
    }
}