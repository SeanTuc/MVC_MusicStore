using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_music_store.Startup))]
namespace MVC_music_store
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
