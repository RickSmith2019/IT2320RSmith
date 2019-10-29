using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AuthWithGoogl.Startup))]
namespace AuthWithGoogl
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
