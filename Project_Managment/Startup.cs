using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Project_Managment.Startup))]
namespace Project_Managment
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
