using Pet.Domain.Enum;

namespace Pet.Domain.Models
{
    public class Hospitalization : Accommodation
    {
        public HospitalizationStatusType Status { get; set; }
        
        public Order Order { get; set; }

        public Hospitalization()
        { }
    }
}