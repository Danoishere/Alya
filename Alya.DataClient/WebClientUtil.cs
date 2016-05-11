using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Alya.DataClient
{
    public static class WebClientUtil
    {
        public static async Task<TResult> GetResult<TResult>(this HttpResponseMessage response)
        {
            var jsonResult = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<TResult>(jsonResult);
        }
    }
}
