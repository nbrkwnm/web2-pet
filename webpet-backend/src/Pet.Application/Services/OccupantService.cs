using System.Collections.Generic;
using Pet.Application.Interfaces;
using Pet.Domain.Core.Interfaces.Repositories;
using Pet.Domain.Models;

namespace Pet.Application.Services
{
    public class OccupantApplicationService : BaseApplicationService<Occupant>, IOccupantApplicationService
    {
        public OccupantApplicationService(IBaseRepository<Occupant> repository) : base(repository)
        {
        }
    }
}
