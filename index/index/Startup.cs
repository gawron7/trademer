using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(index.Startup))]
namespace index
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
