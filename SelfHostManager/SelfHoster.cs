using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace SelfHostManager
{
    public class SelfHoster
    {
        public IDisposable Server { get; set; }

        public void Start(ApiBuildParams apiBuildParams)
        {
            if (apiBuildParams.Defaults == null)
                apiBuildParams.Defaults = new { id = RouteParameter.Optional };

            StartOptions startOptions = GetStartOptions(apiBuildParams.Url);

            Server = WebApp.Start(startOptions, (appBuilder) => {
                new Startup().Configuration(appBuilder, apiBuildParams);
            });
        }

        private StartOptions GetStartOptions(string url)
        {
            StartOptions startOptions = new StartOptions();
            startOptions.Urls.Add(url);
            return startOptions;
        }
    }
}
