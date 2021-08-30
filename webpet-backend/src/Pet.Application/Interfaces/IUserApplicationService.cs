using Pet.Application.Dtos;
using System.Collections.Generic;

namespace Pet.Application.Interfaces
{
    public interface IUserApplicationService
    {
        void Add(UserDto userDto);
        void Update(UserDto userDto);
        void Remove(UserDto userDto);
        IEnumerable<UserDto> GetAll();
        UserDto GetById(int id);
    }
}
