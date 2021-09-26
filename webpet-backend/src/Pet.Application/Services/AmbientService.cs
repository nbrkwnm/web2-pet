using System.Collections.Generic;
using Pet.Application.Interfaces;
using Pet.Domain.Core.Interfaces.Repositories;
using Pet.Domain.Models;

namespace Pet.Application.Services
{
    public class AmbientApplicationService : BaseApplicationService<Ambient>, IAmbientApplicationService
    {
        public AmbientApplicationService(IBaseRepository<Ambient> repository) : base(repository)
        {
        }
    }
}
