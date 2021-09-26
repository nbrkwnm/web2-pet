using System.Collections.Generic;
using Pet.Application.Interfaces;
using Pet.Domain.Core.Interfaces.Repositories;
using Pet.Domain.Models;

namespace Pet.Application.Services
{
    public class OrderItemApplicationService : BaseApplicationService<OrderItem>, IOrderItemApplicationService
    {
        public OrderItemApplicationService(IBaseRepository<OrderItem> repository) : base(repository)
        {
        }
    }
}
