using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Locamer.Startup))]
namespace Locamer
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
