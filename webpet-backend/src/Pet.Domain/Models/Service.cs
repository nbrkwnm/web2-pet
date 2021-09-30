using System;
using System.Collections.Generic;
using System.Text;

namespace Pet.Domain.Models
{
    public class Service : BaseAuditEntity
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public TimeSpan ExecutionTime { get; set; }
        
        public Service()
        { }
    }
}
