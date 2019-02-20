using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(asp_first_app.Startup))]
namespace asp_first_app
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
