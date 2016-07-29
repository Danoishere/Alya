using Alya.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Alya.DataAccess
{
    public interface IRepository
    {

    }

    public interface IRepository<TEntity> : IRepository, IDisposable where TEntity : EntityBase
    {
        Task Insert(TEntity entity);
        Task Update(TEntity entity);
        Task Delete(TEntity entity);
        Task DeleteById(int id);

        Task<IEnumerable<TEntity>> GetAll();
        Task<IEnumerable<TEntity>> GetAmount(int amount);
        Task<TEntity> GetById(int id);
        Task<TEntity> GetFirst();

        Task<TEntity> GetSingleByExpression(Expression<Func<TEntity,bool>> expression);
        Task<IEnumerable<TEntity>> GetByExpression(Expression<Func<TEntity,bool>> expression);
    }
}
