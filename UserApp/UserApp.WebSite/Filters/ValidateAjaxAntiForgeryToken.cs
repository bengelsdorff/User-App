using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace UserApp.Filters
{
    public class ValidateAjaxAntiForgeryToken : AuthorizeAttribute
    {
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            var request = filterContext.HttpContext.Request;

            //  Only validate POSTs
            if (request.IsAjaxRequest() && request.HttpMethod == WebRequestMethods.Http.Post)
            {
                var antiForgeryCookie = request.Cookies[AntiForgeryConfig.CookieName];
                var cookieValue = antiForgeryCookie != null
                    ? antiForgeryCookie.Value
                    : null;

                string tokenValue = request.Headers["Token"];
                AntiForgery.Validate(cookieValue, tokenValue);
            }
        }
    }
}