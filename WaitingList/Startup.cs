using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Waitlist.Startup))]
namespace Waitlist
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
