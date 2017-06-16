using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OpenQubit.Portal.Presentation.Web.Startup))]
namespace OpenQubit.Portal.Presentation.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
