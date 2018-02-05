using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(test_app.Startup))]
namespace test_app
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
