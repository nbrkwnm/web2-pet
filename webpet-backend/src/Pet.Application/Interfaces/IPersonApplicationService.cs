using System.Collections.Generic;
using Pet.Application.Dtos;

namespace Pet.Application.Interfaces
{
    public interface IPersonApplicationService
    {
        void Add(PersonDto personDto);
        void Update(PersonDto personDto);
        void Remove(PersonDto personDto);
        IEnumerable<PersonDto> GetAll();
        PersonDto GetById(int id);
    }
}