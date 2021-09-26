using System.Collections.Generic;
using Pet.Application.Interfaces;
using Pet.Domain.Core.Interfaces.Repositories;
using Pet.Domain.Models;

namespace Pet.Application.Services
{
    public class PriceListApplicationService : BaseApplicationService<PriceList>, IPriceListApplicationService
    {
        public PriceListApplicationService(IBaseRepository<PriceList> repository) : base(repository)
        {
        }
    }
}
