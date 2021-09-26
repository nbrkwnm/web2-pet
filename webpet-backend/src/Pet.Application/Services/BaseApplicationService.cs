using System.Collections.Generic;
using System.Diagnostics.Contracts;
using Pet.Application.Interfaces;
using Pet.Domain.Core.Interfaces.Repositories;

namespace Pet.Application.Services
{
    public class BaseApplicationService<TEntity> : IApplicationBaseService<TEntity> where TEntity : class
    {
        private IBaseRepository<TEntity> _repository;

        public BaseApplicationService(IBaseRepository<TEntity> repository)
        {
            this._repository = repository;
        }
        public void Add(TEntity person)
        {
            this._repository.Add(person);
        }

        public void Update(TEntity person)
        {
            this._repository.Update(person);
        }

        public void Remove(TEntity entity)
        {
            this._repository.Remove(entity);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return this._repository.GetAll();
        }

        public TEntity GetById(int id)
        {
            return this._repository.GetById(id);
        }
    }
}