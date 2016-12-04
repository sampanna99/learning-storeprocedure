using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LearningStoreProcedure.Startup))]
namespace LearningStoreProcedure
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
