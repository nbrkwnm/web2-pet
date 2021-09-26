using System.Collections.Generic;
using Pet.Application.Interfaces;
using Pet.Domain.Core.Interfaces.Repositories;
using Pet.Domain.Models;

namespace Pet.Application.Services
{
    public class InventoryApplicationService : BaseApplicationService<Inventory>, IInventoryApplicationService
    {
        public InventoryApplicationService(IBaseRepository<Inventory> repository) : base(repository)
        {
        }
    }
}
