using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RederLayout.Startup))]
namespace RederLayout
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
