using System;
using System.Collections.Generic;
using System.Text;

namespace Pet.Domain.Models
{
    public class Customer : Person
    {
        public IList<Animal> Pets { get; set; }

        public Customer()
        {
            Pets = new List<Animal>();
        }

        public Customer(string name, string email, DateTime birthDate, IList<Document> documents)
            : this ()
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;
            Documents = documents;
        }
        
        public void InsertPet(Animal pet)
        {
            if (pet != null)
                Pets.Add(pet);
        }

        public Customer UpdateCustomer(string name, string email, DateTime birthDate, IList<Document> documents)
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;
            Documents = documents;

            return this;
        }
    }
}
