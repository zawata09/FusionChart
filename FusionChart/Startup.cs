using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FusionChart.Startup))]
namespace FusionChart
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
