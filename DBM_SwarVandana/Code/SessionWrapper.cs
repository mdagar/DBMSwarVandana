
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models;
namespace Code
{
    public static class SessionWrapper
    {

        //---------------------------------------------------------------


        public static Users User
        {
            get { return GetFromSession<Users>("User"); }
            set { SetInSession<Users>("User", value); }
        }


        public static string ForSessionOnly
        {
            get { return GetFromSession<string>("ForSessionOnly"); }
            set { SetInSession<string>("ForSessionOnly", value); }
        }

        //----------------------------------------------------------------




        private static T GetFromSession<T>(string key)
        {
            object obj = HttpContext.Current.Session[key];
            if (obj == null)
            {
                return default(T);
            }
            return (T)obj;
        }
        private static void SetInSession<T>(string key, T value)
        {
            if (value == null)
            {
                HttpContext.Current.Session.Remove(key);
            }
            else
            {
                HttpContext.Current.Session[key] = value;
            }
        }
        private static T GetFromApplication<T>(string key)
        {
            return (T)HttpContext.Current.Application[key];
        }
        private static void SetInApplication<T>(string key, T value)
        {
            if (value == null)
            {
                HttpContext.Current.Application.Remove(key);
            }
            else
            {
                HttpContext.Current.Application[key] = value;
            }
        }

    }

}