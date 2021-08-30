using Pet.Application.Dtos;
using Pet.Domain.Models;
using System.Collections.Generic;

namespace Pet.Infrastructure.CrossCutting.Interfaces
{
    public interface IUserMapper
    {
        User MapperDtoToEntity(UserDto userDto);
        IEnumerable<UserDto> MapperListUsersToListDto(IEnumerable<User> users);
        UserDto MapperEntityToDto(User user);
    }
}