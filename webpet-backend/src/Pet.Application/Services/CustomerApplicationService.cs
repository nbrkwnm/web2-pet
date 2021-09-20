using System.Collections.Generic;
using Pet.Application.Interfaces;
using Pet.Domain.Core.Interfaces.Repositories;
using Pet.Domain.Models;

namespace Pet.Application.Services
{
    public class CustomerApplicationService : ICustomerApplicationService
    {
        private readonly ICustomerRepository _repository;
        
        public CustomerApplicationService(ICustomerRepository repository)
        {
            _repository = repository;
        }
    
        public void Add(Customer customer)
        {   
            _repository.Add(customer);
        }

        public void Update(Customer customer)
        {
            _repository.Update(customer);
        }

        public void Remove(Customer customer)
        {
            _repository.Remove(customer);
        }

        public IEnumerable<Customer> GetAll()
        {
            return _repository.GetAll();
        }

        public Customer GetById(int id)
        {
            return _repository.GetById(id);
        }
    }
}