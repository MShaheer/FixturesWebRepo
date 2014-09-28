using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Fixtures.Startup))]
namespace Fixtures
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
