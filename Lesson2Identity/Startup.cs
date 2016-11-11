using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lesson2Identity.Startup))]
namespace Lesson2Identity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
