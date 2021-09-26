using System.Collections.Generic;
using Pet.Application.Interfaces;
using Pet.Domain.Core.Interfaces.Repositories;
using Pet.Domain.Models;

namespace Pet.Application.Services
{
    public class CustomerApplicationService : BaseApplicationService<Customer>, ICustomerApplicationService
    {
        private readonly ICustomerRepository _repository;

        public CustomerApplicationService(IBaseRepository<Customer> repository) : base(repository)
        {
        }
    }
}