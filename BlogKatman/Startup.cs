using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BlogKatman.Startup))]
namespace BlogKatman
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
