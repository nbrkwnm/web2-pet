using System.Collections.Generic;
using Pet.Application.Interfaces;
using Pet.Domain.Core.Interfaces.Repositories;
using Pet.Domain.Models;

namespace Pet.Application.Services
{
    public class AnimalApplicationService : IAnimalApplicationService
    {
        private readonly IPetRepository _repository;
        
        public AnimalApplicationService()
        { }
        
        public AnimalApplicationService(IPetRepository repository)
        {
            _repository = repository;
        }

        public void Add(Animal animal)
        {
            _repository.Add(animal);
        }

        public void Update(Animal animal)
        {
            _repository.Update(animal);
        }

        public void Remove(Animal animal)
        {
            _repository.Remove(animal);
        }

        public IEnumerable<Animal> GetAll()
        {
            return _repository.GetAll();
        }

        public Animal GetById(int id)
        {
            return _repository.GetById(id);;
        }
    }
}