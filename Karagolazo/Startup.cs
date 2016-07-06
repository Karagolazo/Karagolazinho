using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Karagolazo.Startup))]
namespace Karagolazo
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
