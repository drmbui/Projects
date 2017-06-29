using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GreatLand.Startup))]
namespace GreatLand
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
