using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Equity1.Startup))]
namespace Equity1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
