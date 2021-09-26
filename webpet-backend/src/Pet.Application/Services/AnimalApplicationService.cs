using System.Collections.Generic;
using Pet.Application.Interfaces;
using Pet.Domain.Core.Interfaces.Repositories;
using Pet.Domain.Models;

namespace Pet.Application.Services
{
    public class AnimalApplicationService : BaseApplicationService<Animal>, IAnimalApplicationService
    {
        public AnimalApplicationService(IBaseRepository<Animal> repository) : base(repository)
        {
        }
    }
}