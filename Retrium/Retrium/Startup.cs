using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Retrium.Startup))]
namespace Retrium
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
