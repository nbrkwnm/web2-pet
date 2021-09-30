using System;
using Pet.Domain.Enum;

namespace Pet.Domain.Models
{
    public class CashRegisterEvent : BaseEntity
    {
        public int Id { get; set; }
        public CashRegisterEventType Type { get; set; }
        public DateTime Date { get; set; }
        public int CashRegisterId { get; set; }
        public virtual CashRegister CashRegister { get; set; }

        public CashRegisterEvent()
        { }
    }
}