using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(git001.Startup))]
namespace git001
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
