using Pet.Application.Dtos;
using Pet.Application.Interfaces;
using System.Collections.Generic;
using Pet.Application.Interfaces.Mappers;
using Pet.Domain.Core.Interfaces.Services;

namespace Pet.Application
{
    public class UserApplicationService : IUserApplicationService
    {
        private readonly IUserService _userService;
        private readonly IUserMapper _userMapper;

        public UserApplicationService(IUserService userService, IUserMapper userMapper)
        {
            _userService = userService;
            _userMapper = userMapper;
        }
        
        public void Add(UserDto userDto)
        {
            var user = _userMapper.MapperDtoToEntity(userDto);
            
            _userService.Add(user);
        }

        public IEnumerable<UserDto> GetAll()
        {
            return _userMapper.MapperListUsersToListDto(_userService.GetAll());
        }

        public UserDto GetById(int id)
        {
            return _userMapper.MapperEntityToDto(_userService.GetById(id));
        }

        public void Remove(UserDto userDto)
        {
            var user = _userMapper.MapperDtoToEntity(userDto);
            
            _userService.Remove(user);
        }

        public void Update(UserDto userDto)
        {
            var user = _userMapper.MapperDtoToEntity(userDto);
            
            _userService.Update(user);
        }
    }
}
