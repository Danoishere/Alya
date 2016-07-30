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
        public ActionResult About()
        {
            return AlyaView();
        }

        public ActionResult Contact()
        {
            return AlyaView();
        }

        public ActionResult Overview()
        {
            ViewBag.ShowIntroHeader = true;
            return AlyaView();
        }

        public ActionResult MySkills()
        {
            ViewBag.SkillList = ApplicationData.Instance.Skills;
            return AlyaView();
        }

        public ActionResult Qualification()
        {
            return AlyaView();
        }
    }
}