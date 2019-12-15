using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AuthLesson.Startup))]
namespace AuthLesson
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
