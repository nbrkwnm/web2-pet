using System.Collections.Generic;
using Pet.Application.Dtos;
using Pet.Domain.Models;

namespace Pet.Application.Interfaces.Mappers
{
    public interface IUserMapper
    {
        User MapperDtoToEntity(UserDto userDto);
        IEnumerable<UserDto> MapperListUsersToListDto(IEnumerable<User> users);
        UserDto MapperEntityToDto(User user);
    }
}