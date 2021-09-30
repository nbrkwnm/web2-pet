namespace Pet.Domain.Models
{
    public class Occupant : BaseEntity
    {
        public int Id { get; set; }
        public int AnimalId { get; set; }
        public virtual Animal Animal { get; set; }

        public Occupant()
        { }
    }
}