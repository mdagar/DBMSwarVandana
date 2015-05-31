using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Configuration;
namespace Code
{
    public class ConfigurationWrapper
    {
        public static int PageSize
        {
            get { return GetValue<int>("PageSize"); }
        }

        public static string PostImages
        {
            get { return GetValue<string>("PostImages"); }
        }
        public static string TempCollection
        {
            get { return GetValue<string>("TempCollection"); }
        }

        public static string ErrorLogs
        {
            get { return GetValue<string>("ErrorLogs"); }
        }

        public static string SiteLink
        {
            get { return GetValue<string>("SiteLink"); }
        }

        public static string ConnectionString
        {
            get { return GetValue<string>("ConnectionString"); }
        }
        public static string Pictures
        {
            get { return GetValue<string>("Pictures"); }
        }
        


        /// <summary>
        ///  SMTP Details
        /// </summary>
        public static string SMTP_SERVER
        {
            get { return GetValue<string>("SMTP_SERVER"); }
        }

        public static string SMTP_USER
        {
            get { return GetValue<string>("SMTP_USER"); }
        }
        public static string SMTP_PASSWORD
        {
            get { return GetValue<string>("SMTP_PASSWORD"); }
        }
        public static string SMTP_FROM
        {
            get { return GetValue<string>("SMTP_FROM"); }
        }

        public static int SMTP_PORT
        {
            get { return GetValue<int>("SMTP_PORT"); }
        }



        public static T GetValue<T>(string key)
        {
            var o = TypeDescriptor.GetConverter(typeof(T));
            if (o != null)
            {
                return (T)o.ConvertFromString(ConfigurationManager.AppSettings[key]);
            }
            return default(T);
        }
    }
}