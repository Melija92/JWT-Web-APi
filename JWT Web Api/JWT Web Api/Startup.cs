using Microsoft.Owin;
using Owin;
using JWT_Web_Api;

[assembly: OwinStartup(typeof(JWT_Web_Api.Startup))]

namespace JWT_Web_Api
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureOAuth(app);
        }
    }
}