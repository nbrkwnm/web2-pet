using System.Collections.Generic;
using System.Linq;
using Pet.Application.Interfaces;
using Pet.Domain.Core.Interfaces.Repositories;
using Pet.Domain.Models;

namespace Pet.Application.Services
{
    public class UserApplicationService : BaseApplicationService<User>, IUserApplicationService
    {
        private readonly IUserRepository _repository;

        public UserApplicationService(IBaseRepository<User> repository) : base(repository)
        {
        }

        public IEnumerable<User> GetByName(string name)
        {
            throw new System.NotImplementedException();
        }
    }
}
