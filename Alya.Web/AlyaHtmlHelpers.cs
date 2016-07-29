using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Alya.Web
{
    public static class AlyaHtmlHelpers
    {
        public static MvcHtmlString LocalPath(this HtmlHelper htmlHelper, string actionName, string controllerName)
        {
            return new MvcHtmlString("#/" + controllerName + "/" + actionName);
        }
    }
}
