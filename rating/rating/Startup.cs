using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(rating.Startup))]
namespace rating
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
