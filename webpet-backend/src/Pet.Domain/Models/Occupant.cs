namespace Pet.Domain.Models
{
    public class Occupant : BaseEntity
    {
        public Animal Animal { get; set; }

        public Occupant()
        { }
    }
}