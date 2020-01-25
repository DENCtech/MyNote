using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyNote.Startup))]
namespace MyNote
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
