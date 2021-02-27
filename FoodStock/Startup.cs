using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FoodStock.Startup))]
namespace FoodStock
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
