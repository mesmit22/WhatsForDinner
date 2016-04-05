using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Whats_for_dinner.Startup))]
namespace Whats_for_dinner
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
