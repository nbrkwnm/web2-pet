using Pet.Application.Dtos;
using Pet.Application.Interfaces;
using System.Collections.Generic;
using AutoMapper;
using Pet.Domain.Core.Interfaces.Services;
using Pet.Domain.Models;

namespace Pet.Application
{
    public class UserApplicationService : IUserApplicationService
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public UserApplicationService(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }
        
        public void Add(UserDto userDto)
        {
            _userService.Add(_mapper.Map<User>(userDto));
        }

        public IEnumerable<UserDto> GetAll()
        {
            return _mapper.Map<IEnumerable<UserDto>>(_userService.GetAll());
        }

        public UserDto GetById(int id)
        {
            return _mapper.Map<UserDto>(_userService.GetById(id));
        }

        public void Remove(UserDto userDto)
        {
            _userService.Remove(_mapper.Map<User>(userDto));
        }

        public void Update(UserDto userDto)
        {
            _userService.Update(_mapper.Map<User>(userDto));
        }
    }
}
