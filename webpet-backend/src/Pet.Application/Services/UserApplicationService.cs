using System.Collections.Generic;
using Pet.Application.Interfaces;
using Pet.Domain.Core.Interfaces.Repositories;
using Pet.Domain.Models;

namespace Pet.Application.Services
{
    public class UserApplicationService : IUserApplicationService
    {
        private readonly IUserRepository _repository;
        
        public UserApplicationService(IUserRepository repository)
        {
            _repository = repository;
        }
        
        public void Add(User user)
        {
            _repository.Add(user);
        }
        
        public void Update(User user)
        {
            _repository.Update(user);
        }
        
        public IEnumerable<User> GetAll()
        {
            return _repository.GetAll();
        }

        public User GetById(int id)
        {
            return _repository.GetById(id);
        }

        public void Remove(User user)
        {
            _repository.Remove(user);
        }
    }
}
