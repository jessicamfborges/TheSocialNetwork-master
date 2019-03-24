using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Cajuine.WebApp.Startup))]
namespace Cajuine.WebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
