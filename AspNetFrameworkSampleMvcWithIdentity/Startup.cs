using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AspNetFrameworkSampleMvcWithIdentity.Startup))]
namespace AspNetFrameworkSampleMvcWithIdentity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
