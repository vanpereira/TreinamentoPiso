using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GestaoPisoComercial.Web.Startup))]
namespace GestaoPisoComercial.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
