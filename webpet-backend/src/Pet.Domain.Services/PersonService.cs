using Pet.Domain.Core.Interfaces.Repositories;
using Pet.Domain.Core.Interfaces.Services;
using Pet.Domain.Models;

namespace Pet.Domain.Services
{
    public class PersonService : BaseService<Person>, IPersonService
    {
        private readonly IPersonRepository _repository;
        
        public PersonService(IPersonRepository repository)
            : base(repository)
        {
            _repository = repository;
        }
    }
}