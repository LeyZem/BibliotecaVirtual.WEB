using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BibliotecaVirtualWeb.Startup))]
namespace BibliotecaVirtualWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
