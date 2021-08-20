namespace Pet.Domain.Models
{
    public class User : BaseAuditEntity
    {
        public string Username { get; private set; }
        public string Password { get; private set; }
        public Person Person { get; private set; }

        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}
