using System.Collections.Generic;
using Pet.Application.Interfaces;
using Pet.Domain.Core.Interfaces.Repositories;
using Pet.Domain.Models;

namespace Pet.Application.Services
{
    public class HospitalizationApplicationService : BaseApplicationService<Hospitalization>, IHospitalizationApplicationService
    {
        public HospitalizationApplicationService(IBaseRepository<Hospitalization> repository) : base(repository)
        {
        }
    }
}
