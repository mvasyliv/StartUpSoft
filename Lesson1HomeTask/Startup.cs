using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lesson1HomeTask.Startup))]
namespace Lesson1HomeTask
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
