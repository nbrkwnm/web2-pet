using System;
using System.Collections.Generic;
using System.Text;

namespace Pet.Domain.Models
{
    public class Costumer : BaseAuditEntity
    {
        public Person Person { get; set; }

        public IList<Pet> Pets { get; set; }
    }
}
