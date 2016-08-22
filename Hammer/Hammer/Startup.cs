using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Hammer.Startup))]
namespace Hammer
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
