using System.Collections.Generic;
using Pet.Application.Interfaces;
using Pet.Domain.Core.Interfaces.Repositories;
using Pet.Domain.Models;

namespace Pet.Application.Services
{
    public class CashRegisterEventApplicationService : BaseApplicationService<CashRegisterEvent>, ICashRegisterEventApplicationService
    {
        public CashRegisterEventApplicationService(IBaseRepository<CashRegisterEvent> repository) : base(repository)
        {
        }
    }
}
