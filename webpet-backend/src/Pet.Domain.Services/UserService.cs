using Pet.Domain.Core.Interfaces.Repositories;
using Pet.Domain.Core.Interfaces.Services;
using Pet.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pet.Domain.Services
{
    public class UserService : BaseService<User>, IUserService
    {
        private readonly IUserRepository _repository;

        public UserService(IUserRepository repository)
            : base(repository)
        {
            _repository = repository;
        }
    }
}
