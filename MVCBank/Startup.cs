using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCBank.Startup))]
namespace MVCBank
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
