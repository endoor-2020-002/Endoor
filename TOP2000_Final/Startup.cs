using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TOP2000_Final.Startup))]
namespace TOP2000_Final
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
