using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Assignment3_M.Nasir.Startup))]
namespace Assignment3_M.Nasir
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
