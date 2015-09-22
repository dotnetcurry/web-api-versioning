using System;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Dispatcher;
using System.Net;

namespace WebApi_Versioning_CustomHeaders.ControllerSelector
{
    public class CustomHeaderControllerSelector : DefaultHttpControllerSelector
    {
        public CustomHeaderControllerSelector(HttpConfiguration cfg) : base(cfg)
        {}

        public override string GetControllerName(System.Net.Http.HttpRequestMessage request)
        {
            string controllerName = base.GetControllerName(request);
            int controllerVersion;
            if (request.Headers.Contains("X-Version"))
            {
                string headerValue = request.Headers.GetValues("X-Version").First();
                //If the X-Version is 0 then return the default version
                if (headerValue == "0") {
                    return controllerName;
                }

                //If the X-Version is 1 or 2 and if the ControllerName contains 'V or v' the return
                //the controller
                if (!String.IsNullOrEmpty(headerValue) && Int32.TryParse(headerValue, out controllerVersion))
                {
                    controllerName = String.Format("{0}v{1}", controllerName, controllerVersion);

                    HttpControllerDescriptor controllerDesc = null;

                    if (!this.GetControllerMapping().TryGetValue(controllerName, out controllerDesc))
                    {
                        string message = "No HTTP resource was found for specified request URI {0} and version {1}";
                        throw new HttpResponseException(request.CreateErrorResponse(HttpStatusCode.NotFound, String.Format(message, request.RequestUri, controllerVersion)));
                    }
                }
            }
            return controllerName;
        }
    }
}