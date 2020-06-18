using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Top200Wiki.Startup))]
namespace Top200Wiki
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
