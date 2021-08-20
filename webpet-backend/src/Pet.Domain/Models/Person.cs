using System;

namespace Pet.Domain.Models
{
    public class Person : BaseAuditEntity
    {
        public string Name { get; private set; }
        public string Email { get; private set; }
        public DateTime BirthDate { get; set; }

        public Person(string nome, string email)
        {
            Name = nome;
            Email = email;
        }
    }
}
