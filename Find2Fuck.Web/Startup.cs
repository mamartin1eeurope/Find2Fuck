using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Find2Fuck.Web.Startup))]
namespace Find2Fuck.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
