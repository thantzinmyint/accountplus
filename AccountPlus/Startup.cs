using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AccountPlus.Startup))]
namespace AccountPlus
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
