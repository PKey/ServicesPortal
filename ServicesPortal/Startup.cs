using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ServicesPortal.Startup))]
namespace ServicesPortal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
