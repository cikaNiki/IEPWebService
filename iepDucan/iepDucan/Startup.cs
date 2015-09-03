using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(iepDucan.Startup))]
namespace iepDucan
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
