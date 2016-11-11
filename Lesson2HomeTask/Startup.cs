using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lesson2HomeTask.Startup))]
namespace Lesson2HomeTask
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
