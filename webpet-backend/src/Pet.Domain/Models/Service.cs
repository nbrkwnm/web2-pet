using System;
using System.Collections.Generic;
using System.Text;

namespace Pet.Domain.Models
{
    public class Service : BaseAuditEntity
    {
        public string Description { get; set; }
        public TimeSpan ExecutionTime { get; set; }
        
        public Service()
        { }
    }
}
