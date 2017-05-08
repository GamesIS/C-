using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UncleGabenShop.Startup))]
namespace UncleGabenShop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
