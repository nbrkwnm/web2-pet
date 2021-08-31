using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pet.Domain.Models
{
    public class User : BaseAuditEntity
    {
        public string Username { get; set; }
        public string Password { get; set; }
        [ForeignKey(nameof(Id))]
        public Person Person { get; set; }
        public IList<Permission> Permissions { get; set; }

        public User()
        { }
        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }

        
    }
}
