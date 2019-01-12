using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FoodGallery.Startup))]
namespace FoodGallery
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
