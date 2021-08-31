using System.Collections.Generic;
using AutoMapper;
using Pet.Application.Dtos;
using Pet.Application.Interfaces;
using Pet.Domain.Core.Interfaces.Services;
using Pet.Domain.Models;

namespace Pet.Application
{
    public class PersonApplicationService : IPersonApplicationService
    {
        private readonly IPersonService _personService;
        private readonly IMapper _mapper;
        
        public PersonApplicationService(IPersonService personService, IMapper mapper)
        {
            _personService = personService;
            _mapper = mapper;
        }
        
        public void Add(PersonDto personDto)
        {
            _personService.Add(_mapper.Map<Person>(personDto));
        }

        public IEnumerable<PersonDto> GetAll()
        {
            return _mapper.Map<IEnumerable<PersonDto>>(_personService.GetAll());
        }

        public PersonDto GetById(int id)
        {
            return _mapper.Map<PersonDto>(_personService.GetById(id));
        }

        public void Remove(PersonDto personDto)
        {
            _personService.Remove(_mapper.Map<Person>(personDto));
        }

        public void Update(PersonDto personDto)
        {
            _personService.Update(_mapper.Map<Person>(personDto));
        }
    }
}