using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VinylStore.Startup))]
namespace VinylStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
