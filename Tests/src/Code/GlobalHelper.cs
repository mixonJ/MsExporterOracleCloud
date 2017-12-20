using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Hosting;
using OracleCloud.Controllers;

namespace Tests {
    public static class GlobalHelper {
        public static HttpRequestMessage GetRequestObject(OracleController controller){
            controller.Request = new HttpRequestMessage();
            controller.Request.Properties.Add(HttpPropertyKeys.HttpConfigurationKey, new HttpConfiguration());
            return controller.Request;
        }
    }
}
