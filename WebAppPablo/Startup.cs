using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppPablo.Startup))]
namespace WebAppPablo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
