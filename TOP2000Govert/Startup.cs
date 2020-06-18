using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TOP2000Govert.Startup))]
namespace TOP2000Govert
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
