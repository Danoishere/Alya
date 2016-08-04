using Alya.MailEngine;
using Alya.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        [HttpGet]
        public ActionResult Contact()
        {
            return AlyaView();
        }

        [HttpPost]
        public async Task<ActionResult> Contact(string message)
        {
            var client = new MailClient("vietnambiketrader@gmail.com", "ILoveHanoi2016");
            await client.SendEmail("dano.roesti@gmail.com", "Someone tries to contact you!", message);

            ViewBag.Message = "Your message has been sucessfully sent to Dano!";

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