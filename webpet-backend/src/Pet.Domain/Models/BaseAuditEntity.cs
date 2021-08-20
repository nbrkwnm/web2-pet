using System;

namespace Pet.Domain.Models
{
    public class BaseAuditEntity : BaseEntity
    {
        public DateTime CreatedAt { get; private set; }
        public DateTime UpdatedAt { get; private set; }
    }
}
