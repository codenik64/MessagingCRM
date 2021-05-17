using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MessagingCRM.Startup))]
namespace MessagingCRM
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
