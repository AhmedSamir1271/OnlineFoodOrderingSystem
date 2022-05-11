using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApplication7SE2.Startup))]
namespace WebApplication7SE2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
