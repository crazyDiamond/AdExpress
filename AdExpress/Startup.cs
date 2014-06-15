using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AdExpress.Startup))]
namespace AdExpress
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
