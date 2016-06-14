using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Objects1.Startup))]
namespace Objects1
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
