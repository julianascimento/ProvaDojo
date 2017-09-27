using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProvaDojo.Startup))]
namespace ProvaDojo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
