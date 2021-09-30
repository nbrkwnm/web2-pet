using System;
using System.Collections.Generic;

namespace Pet.Domain.Models
{
    public class Person : BaseAuditEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public IList<Document> Documents { get; set; }

        public Person()
        {
            Documents = new List<Document>();
        }
        public Person(string nome, string email)
            : base()
        {
            Name = nome;
            Email = email;
        }
    }
}
