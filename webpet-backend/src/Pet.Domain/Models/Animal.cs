using System;
using Pet.Domain.Enum;

namespace Pet.Domain.Models
{
    public class Animal : BaseAuditEntity
    {
        public string Name { get; set; }
        public PetType Type { get; set; }
        public DateTime BirthDate { get; set; }

        public Animal()
        { }

        public Animal(string name, PetType type, DateTime birthDate)
        {
            Name = name;
            Type = type;
            BirthDate = birthDate;
        }

        public Animal UpdatePet(string name, PetType type, DateTime birthDate)
        {
            Name = name;
            Type = type;
            BirthDate = birthDate;

            return this;
        }
    }
}
