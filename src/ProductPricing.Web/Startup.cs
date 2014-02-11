using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProductPricing.Web.Startup))]
namespace ProductPricing.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
