using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Alya.DataClient
{
    public static class WebClientConfiguration
    {
        public static string ServiceBaseAddress { get; set; }
        public static int Timeout { get; set; } = 10000;
    }

    public static class WebClientFactory
    {
        public static HttpClient Create()
        {
            var client = new HttpClient
            {
                BaseAddress = new Uri(WebClientConfiguration.ServiceBaseAddress),
                Timeout = new TimeSpan(WebClientConfiguration.Timeout),                
            };

            return client;
        }

        public static HttpClient Create<TEntityType>()
        {
            var client = new HttpClient
            {
                
                BaseAddress = new Uri(WebClientConfiguration.ServiceBaseAddress + "\\" + typeof(TEntityType).Name),
                Timeout = new TimeSpan(WebClientConfiguration.Timeout),
            };

            return client;
        }
    }
}
