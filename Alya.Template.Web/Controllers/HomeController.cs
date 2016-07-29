using Alya.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Alya.Template.Web.Controllers
{
    [Authorize]
    public class HomeController : AlyaMvcController
    {
        public ActionResult Index()
        {
            ViewBag.ShowIntroHeader = true;
            return AlyaView();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return AlyaView();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return AlyaView();
        }

        public ActionResult Overview()
        {
            ViewBag.ShowIntroHeader = true;
            return AlyaView();
        }
    }
}