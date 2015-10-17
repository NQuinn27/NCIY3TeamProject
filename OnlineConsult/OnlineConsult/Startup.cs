using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OnlineConsult.Startup))]
namespace OnlineConsult
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
