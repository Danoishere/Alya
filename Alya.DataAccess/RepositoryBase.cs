using Alya.Core;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Alya.DataAccess
{

    public static class RepositoryFactory
    {
        public static IRepository<TRepositoryEntity> Create<TRepositoryEntity>() where TRepositoryEntity : EntityBase
        {
            return Activator.CreateInstance<RepositoryBase<TRepositoryEntity>>();
        }
    }

    public class RepositoryBase<TEntity> : IRepository<TEntity> where TEntity : EntityBase
    {
        protected RepositoryBase(){}

        public async Task Delete(TEntity entity)
        {
            using (var context = DataAccess.Context)
            {
                context.Entry(entity).State = EntityState.Deleted;
                await context.SaveChangesAsync();
            }
        }

        public async Task DeleteById(int id)
        {
            using (var context = DataAccess.Context)
            {
                var entry = await context.Set<TEntity>().FindAsync(id);
                context.Entry(entry).State = EntityState.Deleted;
                await context.SaveChangesAsync();
            }
        }

        public async Task<IList<TEntity>> GetAll()
        {
            using (var context = DataAccess.Context)
            {
                return await context
                    .Set<TEntity>()
                    .AsNoTracking()
                    .ToListAsync();
            }
        }

        public async Task<IList<TEntity>> GetByExpression(Expression<Func<TEntity, bool>> expression)
        {
            using (var context = DataAccess.Context)
            {
                return await context.Set<TEntity>()
                    .Where(expression)
                    .AsNoTracking()
                    .ToListAsync();
            }
        }

        public async Task<TEntity> GetById(int id)
        {
            using (var context = DataAccess.Context)
            {
                return await context.Set<TEntity>().FindAsync(id);
            }
        }

        public async Task<TEntity> GetFirst()
        {
            using (var context = DataAccess.Context)
            {
                return await context.Set<TEntity>().FirstOrDefaultAsync();
            }
        }

        public async Task<TEntity> GetSingleByExpression(Expression<Func<TEntity, bool>> expression)
        {
            using (var context = DataAccess.Context)
            {
                return await context.Set<TEntity>()
                    .Where(expression)
                    .AsNoTracking()
                    .FirstOrDefaultAsync();
            }
        }

        public async Task Insert(TEntity entity)
        {
            using (var context = DataAccess.Context)
            {
                context.Set<TEntity>().Add(entity);
                await context.SaveChangesAsync();
            }
        }

        public async Task Update(TEntity entity)
        {
            using (var context = DataAccess.Context)
            {
                context.Entry(entity).State = EntityState.Modified;
                await context.SaveChangesAsync();
            }
        }
    }
}
