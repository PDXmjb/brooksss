using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(brooksss.Startup))]
namespace brooksss
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
