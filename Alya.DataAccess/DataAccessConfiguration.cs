using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alya.DataAccess
{
    public class DataAccess
    {
        private static DataAccess configuration;
        public static DataAccess Configuration
        {
            get
            {
                if(configuration == null)
                {
                    configuration = new DataAccess();
                }
                return configuration;
            }
        }

        public Type DbContextType { get; set; }
        public string NameOrConnectionString { get; set; }
        private DataAccess(){}


        public static AlyaDbContextBase Context
        {
            get
            {
                var parameters = new string[] { Configuration.NameOrConnectionString };
                var context = Activator.CreateInstance(Configuration.DbContextType, parameters) as AlyaDbContextBase;
                if(context != null)
                {
                    return context;
                }

                throw new Exception("No activable context type found");
            }
        }
    }
}
