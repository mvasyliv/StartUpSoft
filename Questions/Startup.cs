using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Questions.Startup))]
namespace Questions
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
