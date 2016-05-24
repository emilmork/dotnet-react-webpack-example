using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ReactDemo.Startup))]
namespace ReactDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            
        }
    }
}
