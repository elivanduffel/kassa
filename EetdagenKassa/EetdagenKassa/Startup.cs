using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EetdagenKassa.Startup))]
namespace EetdagenKassa
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
