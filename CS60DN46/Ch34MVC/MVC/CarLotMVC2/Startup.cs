using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CarLotMVC2.Startup))]
namespace CarLotMVC2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
