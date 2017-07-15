using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Dosial.Web.UI.Startup))]
namespace Dosial.Web.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
