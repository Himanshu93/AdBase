using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AdBase.Startup))]
namespace AdBase
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
