using Alya.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using Alya.DataAccess;

namespace Alya.WebAPI
{
    public class AlyaApiController<TEntityBase> : ApiController where TEntityBase : EntityBase
    {
        public async Task<IHttpActionResult> Insert(EntityBase entity)
        {
            
        }
    }
}
