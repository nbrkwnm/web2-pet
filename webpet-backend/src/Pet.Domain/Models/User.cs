using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pet.Domain.Models
{
    public class User// : Person
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int PersonId { get; set; }
        public virtual Person Person { get; set; }

        public User()
        { }
        
        // public User(string name, string username, string password, string email, DateTime birthDate, IList<Document> documents)
        //     : this()
        // {
        //     Name = name;
        //     Username = username;
        //     Password = password;
        //     Email = email;
        //     BirthDate = birthDate;
        //     Documents = documents;
        // }
    }
}
