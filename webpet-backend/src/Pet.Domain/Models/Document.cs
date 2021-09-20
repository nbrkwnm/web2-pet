using System;
using System.Collections.Generic;
using System.Text;
using Pet.Domain.Enum;

namespace Pet.Domain.Models
{
    public class Document : BaseAuditEntity
    {
        public DocumentType Type { get; set; }
        public string Number { get; set; }

        public Document()
        { }

        public Document(DocumentType type, string number)
        {
            Type = type;
            Number = number;
        }
    }
}
