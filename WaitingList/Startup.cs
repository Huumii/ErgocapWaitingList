using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WaitingList.Startup))]
namespace WaitingList
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
