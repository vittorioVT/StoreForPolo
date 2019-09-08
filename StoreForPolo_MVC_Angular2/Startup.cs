using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StoreForPolo_MVC_Angular2.Startup))]
namespace StoreForPolo_MVC_Angular2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
