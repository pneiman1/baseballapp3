using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(baseballapp3.Startup))]
namespace baseballapp3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
