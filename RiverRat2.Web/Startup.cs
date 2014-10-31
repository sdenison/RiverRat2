using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RiverRat2.Web.Startup))]
namespace RiverRat2.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
