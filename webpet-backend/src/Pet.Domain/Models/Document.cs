using System;
using System.Collections.Generic;
using System.Text;
using Pet.Domain.Enum;

namespace Pet.Domain.Models
{
    public class Document : BaseAuditEntity
    {
        public int Id { get; set; }
        public DocumentType Type { get; set; }
        public string Number { get; set; }
        public int PersonId { get; set; }
        public virtual Person Person { get; set; }

        public Document()
        { }

        public Document(DocumentType type, string number)
        {
            Type = type;
            Number = number;
        }
    }
}
