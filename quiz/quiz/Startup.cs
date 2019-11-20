using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(quiz.Startup))]
namespace quiz
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
