using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfHostManager
{
    public class ApiBuildParams
    {
        public string Url           { get; set; }
        public string Name          { get; set; }
        public string RouteTemplate { get; set; }
        public object Defaults      { get; set; }
    }
}
