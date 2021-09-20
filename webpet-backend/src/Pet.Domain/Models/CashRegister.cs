using System.Collections.Generic;

namespace Pet.Domain.Models
{
    public class CashRegister : BaseAuditEntity
    {
        public string Code { get; set; }
        public bool IsOpen { get; set; }
        public User User { get; set; }
        public IList<CashRegisterEvent> Events { get; set; }

        public CashRegister()
        {
            Events = new List<CashRegisterEvent>();
        }
    }
}