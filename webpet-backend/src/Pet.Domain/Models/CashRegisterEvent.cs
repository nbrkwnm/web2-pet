using System;
using Pet.Domain.Enum;

namespace Pet.Domain.Models
{
    public class CashRegisterEvent : BaseEntity
    {
        public CashRegisterEventType Type { get; set; }
        public DateTime Date { get; set; }

        public CashRegisterEvent()
        { }
    }
}