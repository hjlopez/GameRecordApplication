using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GameRecordApplication.Startup))]
namespace GameRecordApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
