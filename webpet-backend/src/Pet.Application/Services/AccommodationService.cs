using System.Collections.Generic;
using Pet.Application.Interfaces;
using Pet.Domain.Core.Interfaces.Repositories;
using Pet.Domain.Models;

namespace Pet.Application.Services
{
    public class AccommodationApplicationService : BaseApplicationService<Accommodation>, IAccommodationApplicationService
    {
        public AccommodationApplicationService(IBaseRepository<Accommodation> repository) : base(repository)
        {
        }
    }
}
