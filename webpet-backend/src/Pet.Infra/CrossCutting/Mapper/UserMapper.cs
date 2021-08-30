using System.Collections.Generic;
using System.Linq;
using Pet.Application.Dtos;
using Pet.Domain.Models;
using Pet.Infrastructure.CrossCutting.Interfaces;

namespace Pet.Infrastructure.CrossCutting.Mapper
{
    public class UserMapper : IUserMapper
    {
        private IEnumerable<UserDto> _usersDto = new List<UserDto>();

        public User MapperDtoToEntity(UserDto userDto)
        {
            var user = new User()
            {
                Id = userDto.Id,
                Username = userDto.Username,
                Password = userDto.Password,
                Person = userDto.Person,
            };
            
            return user;
        }
        
        public UserDto MapperEntityToDto(User user)
        {
            var userDto = new UserDto()
            {
                Id = user.Id,
                Person = user.Person,
                Username = user.Username,
                Password = user.Password
            };

            return userDto;
        }

        public IEnumerable<UserDto> MapperListUsersToListDto(IEnumerable<User> users)
        {
            return users.Select(c => new UserDto {Id = c.Id, 
                                                        Person = c.Person, 
                                                        Username = c.Username, 
                                                        Password = c.Password});
        }
    }
}