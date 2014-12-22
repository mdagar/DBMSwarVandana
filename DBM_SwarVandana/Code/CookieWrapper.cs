using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Code
{
    public class CookieWrapper
    {
        private const string ApplicationName = "DBM_SwarVandana";

        private enum CookieItem
        {
            PageSize,
            UniqueId,
            LoginKey
        }
        /**************
        All cookie values are accessible by public static methods.
        No typos/duplicates are possible from calling code!
        **************/

        public static int PageSize
        {
            get { return Convert.ToInt32(string.IsNullOrWhiteSpace(GetCookieVal(CookieItem.PageSize)) ? "10" : GetCookieVal(CookieItem.PageSize)); }
            set { UpdateCookieVal(CookieItem.PageSize, value.ToString(), 40); }
        }

        public static int UniqueId
        {
            get { return Convert.ToInt32(string.IsNullOrWhiteSpace(GetCookieVal(CookieItem.UniqueId)) ? "0" : GetCookieVal(CookieItem.UniqueId)); }
            set { UpdateCookieVal(CookieItem.UniqueId, value.ToString(), 40); }
        }



        public static string LoginKey
        {
            get { return GetCookieVal(CookieItem.LoginKey) ?? string.Empty; }
            set { UpdateCookieVal(CookieItem.LoginKey, value.ToString(), 40); }
        }


        private static string GetCookieVal(CookieItem item)
        {
            HttpCookie cookie = GetAppCookie(false); //get the existing cookie
            return (cookie != null && (cookie.Values[item.ToString()] != null)) //value or empty if doesn't exist
                ? cookie.Values[item.ToString()]
                : string.Empty;
        }

        private static void UpdateCookieVal(CookieItem item, string val, int expireMinute)
        {
            //get the existing cookie (or new if not exists)
            HttpCookie cookie = GetAppCookie(true);

            //modify its contents & meta.
            cookie.Expires = DateTime.Now.AddMinutes(expireMinute);
            cookie.Values[item.ToString()] = val;

            //add back to the http response to send back to the browser
            HttpContext.Current.Response.Cookies.Add(cookie);
        }

        private static HttpCookie GetAppCookie(bool createIfDoesntExist)
        {
            if (HttpContext.Current == null)
                return null;
            //get the cookie or a new one if indicated
            return HttpContext.Current.Request.Cookies[ApplicationName] ?? ((createIfDoesntExist) ? new HttpCookie(ApplicationName) : null);
        }
    }
}