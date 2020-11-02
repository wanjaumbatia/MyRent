using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyRent.Startup))]
namespace MyRent
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
