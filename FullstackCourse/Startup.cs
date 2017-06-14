using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FullstackCourse.Startup))]
namespace FullstackCourse
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
