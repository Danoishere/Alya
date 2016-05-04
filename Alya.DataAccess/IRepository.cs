using Alya.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Alya.DataAccess
{
    public interface IRepository<TEntity> where TEntity : EntityBase
    {
        Task Insert(TEntity entity);
        Task Update(TEntity entity);
        Task Delete(TEntity entity);
        Task DeleteById(int id);

        Task<IList<TEntity>> GetAll();
        Task<TEntity> GetById(int id);
        Task<TEntity> GetFirst();

        Task<TEntity> GetSingleByExpression(Expression<Func<bool,TEntity>> expression);
        Task<IList<TEntity>> GetByExpression(Expression<Func<bool, TEntity>> expression);
    }
}
