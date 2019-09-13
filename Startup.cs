using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MIS4200_hm433314.Startup))]
namespace MIS4200_hm433314
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
