using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Event_Website.Startup))]
namespace Event_Website
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
