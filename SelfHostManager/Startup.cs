using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace SelfHostManager
{
    public class Startup
    {
        public void Configuration(IAppBuilder appBuilder, ApiBuildParams apiBuildParams)
        {
            HttpConfiguration config = new HttpConfiguration();

            config.Routes.MapHttpRoute(
                name: apiBuildParams.Name,
                routeTemplate: apiBuildParams.RouteTemplate,
                defaults: apiBuildParams.Defaults
            );

            appBuilder.UseWebApi(config);
        }
    }
}
