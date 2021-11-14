using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PersonalSiteMVC1.UI.MVC.Startup))]
namespace PersonalSiteMVC1.UI.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
