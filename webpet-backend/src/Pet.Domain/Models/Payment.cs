using System;
using System.Collections.Generic;
using System.Text;
using Pet.Domain.Enum;

namespace Pet.Domain.Models
{
    public class Payment : BaseEntity
    {
        public PaymentType Type { get; set; }
        public decimal Value { get; set; }
        public PaymentSituationType Situation { get; set; }
        
        public Payment()
        { }
    }
}
