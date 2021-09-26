using System.Collections.Generic;
using Pet.Application.Interfaces;
using Pet.Domain.Core.Interfaces.Repositories;
using Pet.Domain.Models;

namespace Pet.Application.Services
{
    public class PriceListItemApplicationService : BaseApplicationService<PriceListItem>, IPriceListItemApplicationService
    {
        public PriceListItemApplicationService(IBaseRepository<PriceListItem> repository) : base(repository)
        {
        }
    }
}
