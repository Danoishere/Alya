using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Alya.Template.Web.Startup))]
namespace Alya.Template.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
