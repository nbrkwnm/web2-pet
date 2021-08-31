using Pet.Domain.Models;

namespace Pet.Application.Dtos
{
    public class UserDto
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public PersonDto Person { get; set; }
    }
}