using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Vidly_MyVersion.Startup))]
namespace Vidly_MyVersion
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
