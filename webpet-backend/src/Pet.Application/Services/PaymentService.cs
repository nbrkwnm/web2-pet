using System.Collections.Generic;
using Pet.Application.Interfaces;
using Pet.Domain.Core.Interfaces.Repositories;
using Pet.Domain.Models;

namespace Pet.Application.Services
{
    public class PaymentApplicationService : BaseApplicationService<Payment>, IPaymentApplicationService
    {
        public PaymentApplicationService(IBaseRepository<Payment> repository) : base(repository)
        {
        }
    }
}
