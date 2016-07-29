using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Alya.Util
{
    public class Text
    {
        public static Dictionary<string, Translator> Languages { get; set; } = new Dictionary<string, Translator>();


        #region Multiton

        private static object syncRoot = new object();

        private Text() { }

        public static dynamic Instance
        {
            get
            {

                lock (syncRoot)
                {
                    if (Languages.ContainsKey(CultureInfo.DefaultThreadCurrentUICulture.Name))
                    {
                        return Languages[CultureInfo.DefaultThreadCurrentUICulture.Name];
                    }
                    return Languages.FirstOrDefault(l => l.Value.IsDefault);
                }
            }
        }
    }
    #endregion
}

public class Translator : DynamicObject
{
    public bool IsDefault { get; set; }
    public Translator()
    {
    }

    public override bool TryGetMember(GetMemberBinder binder, out object result)
    {
        result = "";
        return true;
    }

}
