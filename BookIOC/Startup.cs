using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BookIOC.Startup))]
namespace BookIOC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
