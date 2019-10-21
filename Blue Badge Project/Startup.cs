using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Blue_Badge_Project.Startup))]
namespace Blue_Badge_Project
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
