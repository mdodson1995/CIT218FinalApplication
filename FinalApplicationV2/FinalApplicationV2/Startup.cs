using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FinalApplicationV2.Startup))]
namespace FinalApplicationV2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
