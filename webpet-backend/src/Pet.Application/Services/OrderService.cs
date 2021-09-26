using System.Collections.Generic;
using Pet.Application.Interfaces;
using Pet.Domain.Core.Interfaces.Repositories;
using Pet.Domain.Models;

namespace Pet.Application.Services
{
    public class OrderApplicationService : BaseApplicationService<Order>, IOrderApplicationService
    {
        public OrderApplicationService(IBaseRepository<Order> repository) : base(repository)
        {
        }
    }
}
