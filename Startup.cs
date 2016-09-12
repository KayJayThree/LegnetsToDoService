using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(LegnetsToDoService.Startup))]

namespace LegnetsToDoService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}