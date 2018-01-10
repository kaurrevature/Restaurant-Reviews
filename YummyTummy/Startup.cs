using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(YummyTummy.Startup))]
namespace YummyTummy
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
