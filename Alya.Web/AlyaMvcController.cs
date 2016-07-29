using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Alya.Web
{
    [ForwardMessagesActionFilter]
    public class AlyaMvcController : Controller
    {
        public string ErrorMessage
        {
            get { return TempData["ErrorMessage"] as string; }
            set { TempData["ErrorMessage"] = value; }
        }
        public string SuccessMessage
        {
            get { return TempData["ErrorMessage"] as string; }
            set { TempData["ErrorMessage"] = value; }
        }
        public string Message
        {
            get { return TempData["ErrorMessage"] as string; }
            set { TempData["ErrorMessage"] = value; }
        }

        public ActionResult AlyaView()
        {
            if (HttpContext.Request.IsAjaxRequest())
            {
                return PartialView();
            }
            else
            {
                return View();
            }
        }

        public ActionResult AlyaView(string viewName)
        {
            if (HttpContext.Request.IsAjaxRequest())
            {
                return PartialView(viewName);
            }
            else
            {
                return View(viewName);
            }
        }

        public ActionResult AlyaView(object model)
        {
            if (HttpContext.Request.IsAjaxRequest())
            {
                return PartialView(model);
            }
            else
            {
                return View(model);
            }
        }

        public ActionResult AlyaView(string viewName, object model)
        {
            if (HttpContext.Request.IsAjaxRequest())
            {
                return PartialView(viewName, model);
            }
            else
            {
                return View(viewName, model);
            }
        }
    }
}
