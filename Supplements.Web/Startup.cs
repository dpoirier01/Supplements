using Microsoft.Owin;
using Owin;

[assembly: OwinStartup("WebStartup", typeof(Supplements.Web.Startup))]

namespace Supplements.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
