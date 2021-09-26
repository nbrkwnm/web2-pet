using System.Collections.Generic;
using Pet.Application.Interfaces;
using Pet.Domain.Core.Interfaces.Repositories;
using Pet.Domain.Models;

namespace Pet.Application.Services
{
    public class ProductApplicationService : BaseApplicationService<Product>, IProductApplicationService
    {
        public ProductApplicationService(IBaseRepository<Product> repository) : base(repository)
        {
        }
    }
}
