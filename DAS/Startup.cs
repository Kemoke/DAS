using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DAS.Startup))]
namespace DAS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
