using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjectA_Dependent.Startup))]
namespace ProjectA_Dependent
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
