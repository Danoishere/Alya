using Alya.Core;
using Alya.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;


namespace Alya.DataClient
{
    public class RepositoryClient<TEntity> where TEntity : EntityBase
    {
        public string EntityName { get; set; }
        public RepositoryClient(string entityName)
        {
            EntityName = entityName;
        }

        public RepositoryClient()
        {
            EntityName = typeof(TEntity).Name;
        }

        public async Task Insert(TEntity entity)
        {
            using (var client = WebClientFactory.Create())
            {
                var response = await client.PostAsJsonAsync(EntityName, entity);
                if(response.IsSuccessStatusCode)
                {
                    var result = response.GetResult<TEntity>();
                    result.CopyProperties(entity);
                }
            }
        }

        public async Task Update(TEntity entity)
        {
            using (var client = WebClientFactory.Create())
            {
                var response = await client.PutAsJsonAsync(EntityName, entity);
                if (response.IsSuccessStatusCode)
                {
                    var result = response.GetResult<TEntity>();
                    result.CopyProperties(entity);
                }
            }
        }

        public async Task Delete(TEntity entity)
        {
            using (var client = WebClientFactory.Create())
            {
                await client.DeleteAsync(EntityName + "/" + entity.Id);
            }
        }
        public async Task<TEntity> GetById(int entityId)
        {
            using (var client = WebClientFactory.Create())
            {
                var response = await client.GetAsync(EntityName + "/" + entityId);
                if (response.IsSuccessStatusCode)
                {
                   return await response.GetResult<TEntity>();
                }
                return default(TEntity);
            }
        }

        public async Task<IList<TEntity>> GetAll(int entityId)
        {
            using (var client = WebClientFactory.Create())
            {
                var response = await client.GetAsync(EntityName);
                if (response.IsSuccessStatusCode)
                {
                    return await response.GetResult<IList<TEntity>>();
                }
                return new List<TEntity>();
            }
        }
    }
}
