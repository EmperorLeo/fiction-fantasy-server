using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FictionFantasyServer.Data.Entities.Base;

namespace FictionFantasyServer.Data
{
    public interface IRepository<TEntity> where TEntity : IEntity
    {
        Task<TEntity> GetById(Guid id);
        IQueryable<TEntity> GetAll();
        void Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);
        void Update(TEntity entity);
        void UpdateRange(IEnumerable<TEntity> entities);
        void Delete(TEntity entity);
        void DeleteRange(IEnumerable<TEntity> entities);
    }
}