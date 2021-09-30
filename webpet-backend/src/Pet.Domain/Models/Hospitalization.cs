using Pet.Domain.Enum;

namespace Pet.Domain.Models
{
    public class Hospitalization// : Accommodation
    {
        public int Id { get; set; }
        public HospitalizationStatusType Status { get; set; }
        public int OrderId { get; set; }
        public virtual Order Order { get; set; }
        public int AccommodationId { get; set; }
        public Accommodation Accommodation { get; set; }

        public Hospitalization()
        { }
    }
}