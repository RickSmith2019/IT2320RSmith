using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IndAuthAcct.Startup))]
namespace IndAuthAcct
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
