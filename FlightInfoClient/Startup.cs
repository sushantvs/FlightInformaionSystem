using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FlightInfoClient.Startup))]
namespace FlightInfoClient
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
