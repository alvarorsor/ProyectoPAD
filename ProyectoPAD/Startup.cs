using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProyectoPAD.Startup))]
namespace ProyectoPAD
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
