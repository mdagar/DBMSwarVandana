using System;
using System.Collections.Generic;
using System.EnterpriseServices;
using System.Linq;
using System.Web;
using System.Web.Routing;


namespace System.Web.Mvc
{
    public abstract class DerivedController : Controller
    {
        [Description("RedirectTo message is using to redirect page if action is called by Ajax form")]
        protected internal virtual ContentResult RedirectTo(string action, string controller = null, RouteValueDictionary route = null)
        {

            string _script = @"<script type='text/javascript'>
                                window.location = '" + Url.Action(action, controller, route) + @"'
                              </script>
                            ";

            return Content(_script);
        }
    }
}