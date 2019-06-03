using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SerwisSubskrypcja.Startup))]
namespace SerwisSubskrypcja
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
