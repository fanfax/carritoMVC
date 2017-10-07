using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(carritoMVC.Startup))]
namespace carritoMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
