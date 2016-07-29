using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Alya.Web
{
    public class ForwardMessagesActionFilter : ActionFilterAttribute
    {


        public override void OnActionExecuted(ActionExecutedContext context)
        {
            var tempData = context.Controller.TempData;

            if (!string.IsNullOrEmpty(tempData["Message"] as string))
            {
                context.Controller.ViewBag.Message = tempData["Message"];
            }
            if (!string.IsNullOrEmpty(tempData["ErrorMessage"] as string))
            {
                context.Controller.ViewBag.ErrorMessage = tempData["ErrorMessage"];
            }
            if (!string.IsNullOrEmpty(tempData["SuccessMessage"] as string))
            {
                context.Controller.ViewBag.SuccessMessage = tempData["SuccessMessage"];
            }

            base.OnActionExecuted(context);
        }
    }
}
