using System;

namespace Pet.Domain.Models
{
    public class Accommodation// : Service
    {
        public int Id { get; set; }
        public int AmbientId { get; set; }
        public virtual Ambient Ambient { get; set; }
        public int OccupantId { get; set; }
        public virtual Occupant Occupant { get; set; }
        public DateTime EntryDate { get; set; }
        public DateTime ExitDate { get; set; }
        public int ServiceId { get; set; }
        public Service Service { get; set; }

        public Accommodation()
        { }
    }
}