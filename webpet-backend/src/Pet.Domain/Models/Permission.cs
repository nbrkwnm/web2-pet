using System;
using System.Collections.Generic;
using System.Text;

namespace Pet.Domain.Models
{
    public class Permission : BaseEntity
    {
        public string Role { get; set; }
    }
}
