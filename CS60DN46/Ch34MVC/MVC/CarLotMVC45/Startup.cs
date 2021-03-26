using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CarLotMVC45.Startup))]
namespace CarLotMVC45
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
