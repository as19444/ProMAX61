using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProMAX61.Startup))]
namespace ProMAX61
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
