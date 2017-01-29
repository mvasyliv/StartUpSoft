using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestSS.Startup))]
namespace TestSS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
