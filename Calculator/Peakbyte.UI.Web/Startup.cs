using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Peakbyte.UI.Web.Startup))]
namespace Peakbyte.UI.Web
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
