namespace Pet.Domain.Models
{
    public class BaseEntity
    {
        public int Id { get; private set; }
        public bool IsActive { get; set; }
    }
}
