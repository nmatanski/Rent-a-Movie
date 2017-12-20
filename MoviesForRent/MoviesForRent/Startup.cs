using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MoviesForRent.Startup))]
namespace MoviesForRent
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
