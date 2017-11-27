using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApp_Wls.Startup))]
namespace WebApp_Wls
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
