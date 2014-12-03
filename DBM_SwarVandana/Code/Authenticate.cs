using System;
using System.Web;
using System.Web.Routing;
using Repositories;
using Models;
using System.Collections.Generic;
namespace Code
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class AuthenticateAttribute : System.Web.Mvc.AuthorizeAttribute
    {
        public override void OnAuthorization(System.Web.Mvc.AuthorizationContext filterContext)
        {
            UsersRepository _user = new UsersRepository();
            RouteData routeData = filterContext.RouteData;
            if (SessionWrapper.User == null)
            {
                if (CookieWrapper.UniqueId > 0)
                {
                    var u = _user.UsersGetByUserId(CookieWrapper.UniqueId);
                    SessionWrapper.User = u;
                    if (u.RoleId == (int)UserRole.SuperAdmin)
                    {
                        var center = (new UsersRepository().GetAllCentres());
                        if (center.Count > 0)
                            SessionWrapper.User.CentreId = center[0].CentreId;
                    }
                }
                else
                    filterContext.Result = new System.Web.Mvc.RedirectResult("~/Home");
            }
        }
    }
}
