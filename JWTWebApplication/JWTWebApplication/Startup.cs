using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JWTWebApplication.Startup))]
namespace JWTWebApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
