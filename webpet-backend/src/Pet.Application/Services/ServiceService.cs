using System.Collections.Generic;
using Pet.Application.Interfaces;
using Pet.Domain.Core.Interfaces.Repositories;
using Pet.Domain.Models;

namespace Pet.Application.Services
{
    public class ServiceApplicationService : BaseApplicationService<Service>, IServiceApplicationService
    {
        public ServiceApplicationService(IBaseRepository<Service> repository) : base(repository)
        {
        }
    }
}
