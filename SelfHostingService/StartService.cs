using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace SelfHostingService
{
    public class StartService
    {
        public void Configuration(IAppBuilder appBuilder)
        {
            appBuilder.Map("/api", api =>
            {
                // Create our config object we'll use to configure the API
                //
                var config = new HttpConfiguration();

                // Use attribute routing
                //
                config.MapHttpAttributeRoutes();

                // Now add in the WebAPI middleware
                //
                api.UseWebApi(config);
            });

            //HttpConfiguration config = new HttpConfiguration();
            //config.Routes.MapHttpRoute(name:"OwinAPI", routeTemplate:"owin/{controller}/{id}", defaults: new { id = RouteParameter.Optional });
            //appBuilder.UseWebApi(config);
        }
    }
}
