using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LAWorksSite.Startup))]
namespace LAWorksSite
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
