using System;

namespace Pet.Domain.Models
{
    public class Accommodation : Service
    {
        public Ambient Ambient { get; set; }
        public Occupant Occupant { get; set; }
        public DateTime EntryDate { get; set; }
        public DateTime ExitDate { get; set; }

        public Accommodation()
        { }
    }
}