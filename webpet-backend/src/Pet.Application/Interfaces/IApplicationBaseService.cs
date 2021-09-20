using System.Collections.Generic;

namespace Pet.Application.Interfaces
{
    public interface IApplicationBaseService<TEntity> where TEntity : class
    {
        void Add(TEntity person);
        void Update(TEntity person);
        void Remove(TEntity entity);
        IEnumerable<TEntity> GetAll();
        TEntity GetById(int id);
    }
}