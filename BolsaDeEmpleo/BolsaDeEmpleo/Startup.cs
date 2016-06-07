using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BolsaDeEmpleo.Startup))]
namespace BolsaDeEmpleo
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
