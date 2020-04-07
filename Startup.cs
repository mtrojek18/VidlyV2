using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VidlyV2.Startup))]
namespace VidlyV2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
