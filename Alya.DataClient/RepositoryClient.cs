using Alya.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;


namespace Alya.DataClient
{
    public class RepositoryClient<TEntity>
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

        }

        public async Task Delete(TEntity entity)
        {

        }
    }
}
