using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Collections.Specialized;
using System.Web.Mvc;
using System.Text.RegularExpressions;
using System.ComponentModel;
using System.IO;
using System.Security.Cryptography;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Reflection;
using System.Data;
using System.Web.Routing;
using System.Web.Helpers;
using System.Drawing.Imaging;
using System.Xml;

namespace Code
{
    public static class SystemTime
    {
        public static DateTime Now
        {
            get
            {
                return DateTime.Now.ToUniversalTime();
            }
        }
    }


    public static class Extensions
    {
        private static string[] mobileDevices = new string[] {"iphone","ppc","android",
                                                      "windows ce","blackberry",
                                                      "opera mini","mobile","palm",
                                                      "portable","opera mobi" };

        public static XmlDocument ConvertToXML<T>(this IEnumerable<T> objectToConvert)
        {

            PropertyInfo[] props = typeof(T).GetProperties();
            Type sourceType = objectToConvert.GetType();
            XmlDocument doc = new XmlDocument();
            XmlElement root = doc.DocumentElement;

            XmlElement MainBody = doc.CreateElement(string.Empty, "body", string.Empty);
            doc.AppendChild(MainBody);

            foreach (var v in objectToConvert)
            {
                XmlElement MainNode = doc.CreateElement(string.Empty, "MainNode", string.Empty);
                MainBody.AppendChild(MainNode);

                // Add the properties as columns to the datatable
                foreach (var prop in props)
                {
                    XmlElement node = doc.CreateElement(string.Empty, prop.Name, string.Empty);
                    var value = prop.GetValue(v, null);
                    XmlText text = doc.CreateTextNode(value == null ? "" : value.ToString());
                    node.AppendChild(text);
                    MainNode.AppendChild(node);
                }
            }

            return doc;

        }
        public static bool IsandroidMobileDevice(string useragent)
        {
            return mobileDevices.Any(x => useragent.Contains(x));
        }

        public static string RemoveStringSpaces(string s)
        {
            if (!string.IsNullOrEmpty(s))
            {
                var o = Regex.Replace(s, @"\s", string.Empty);
                return o;
            }
            else return string.Empty;
        }

        public static string CreatePassword(int length)
        {
            string valid = "abcdefghijklmnopqrstuvwxyz1234567890";
            string res = "";
            Random rnd = new Random();
            while (0 < length--)
                res += valid[rnd.Next(valid.Length)];
            return res;
        }

        public static void ToLowerCase(this RouteCollection routes)
        {
            for (int i = 0; i < RouteTable.Routes.Count; i++)
            {
                RouteTable.Routes[i] = new LowerCaseRouteDecorator(RouteTable.Routes[i]);
            }
        }

        public static string Between(this string src, string findFrom, string findTo)
        {
            int start = src.IndexOf(findFrom);
            int to = src.IndexOf(findTo, start + findFrom.Length + 1);
            if (start < 0 || to < 0) return "";
            string s = src.Substring(
                           start + findFrom.Length,
                           to - start - findFrom.Length);
            return s;
        }

        public static byte[] FileToBytes(this string fileName)
        {
            byte[] buff = null;
            FileStream fs = new FileStream(fileName,
                                           FileMode.Open,
                                           FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            long numBytes = new FileInfo(fileName).Length;
            buff = br.ReadBytes((int)numBytes);
            return buff;
        }

        public static IEnumerable<T> Add<T>(this IEnumerable<T> source, params T[] items)
        {
            return source.Concat(items);
        }

        //Convert Array to data Table
        public static DataTable AsDataTable<T>(this IEnumerable<T> enumberable)
        {
            DataTable table = new DataTable("Generated");
            T first = enumberable.FirstOrDefault();
            if (first == null)
                return table;

            PropertyInfo[] properties = first.GetType().GetProperties();
            foreach (PropertyInfo pi in properties)
                table.Columns.Add(pi.Name, pi.PropertyType);

            foreach (T t in enumberable)
            {
                DataRow row = table.NewRow();
                foreach (PropertyInfo pi in properties)
                    row[pi.Name] = t.GetType().InvokeMember(pi.Name, BindingFlags.GetProperty, null, t, null);
                table.Rows.Add(row);
            }

            return table;
        }

        public static string HtmlStrip(this string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return input.IfNullOrEmpty("");
            input = Regex.Replace(input, "<style>(.|\n)*?</style>", string.Empty);
            input = Regex.Replace(input, @"<xml>(.|\n)*?</xml>", string.Empty); // remove all <xml></xml> tags and anything inbetween.  
            return Regex.Replace(input, @"<(.|\n)*?>", string.Empty); // remove any tags but not there content "<p>bob<span> johnson</span></p>" becomes "bob johnson"

        }

        public static string RemoveSpecial(this string s)
        {
            if (!string.IsNullOrWhiteSpace(s))
            {
                Regex re = new Regex("[;\\/:*,-?\"<>|&']");
                return re.Replace(s, " "); ;
            }
            else
                return s;

        }

        [Description("Retrieves an IEnumerable<SelectListItem> from type of enum.")]
        public static IEnumerable<SelectListItem> SelectList<T>(this Type o, bool isDesc = false)
        {
            if (o.IsEnum)
            {
                return Enum.GetValues(typeof(T)).Cast<T>().Select(v => new SelectListItem()
                {
                    Text = isDesc ? (v.GetType()
                                    .GetField(v.ToString())
                                    .GetCustomAttributes(typeof(DescriptionAttribute), false)
                                    .SingleOrDefault() as DescriptionAttribute).Description
                                 : v.ToString(),
                    Value = Convert.ToInt32(v).ToString()
                });
            }
            return null;

        }

        public static IEnumerable<SelectListItem> Intgers(this int from, int to)
        {
            var i = from;
            while (i <= to)
            {
                var s = new SelectListItem();
                s.Text = i.ToString();
                s.Value = i.ToString();
                i++;
                yield return s;
            }
        }


        public static string Desciption(this Enum o)
        {
            DescriptionAttribute attribute = o.GetType()
                .GetField(o.ToString())
                .GetCustomAttributes(typeof(DescriptionAttribute), false)
                .SingleOrDefault() as DescriptionAttribute;
            return attribute == null ? o.ToString() : attribute.Description;
        }

        public static Uri AddQueryString(this Uri uri, string key, dynamic value)
        {
            value = Convert.ToString(value);
            var urlB = new UriBuilder(uri);
            if (string.IsNullOrEmpty(urlB.Query))
            {
                if (!string.IsNullOrEmpty(value)) urlB.Query = string.Format("{0}={1}", key, value);
            }
            else
            {
                var q = urlB.Query.Substring(1); // Remove leading ?
                var nvc = HttpUtility.ParseQueryString(q);
                if (string.IsNullOrEmpty(value))
                {
                    if (nvc.AllKeys.Contains(key)) nvc.Remove(key);
                }
                else
                {
                    nvc[key] = value.ToString();
                }
                urlB.Query = nvc.ToString(); // Overridden HttpValueCollection
            }
            return urlB.Uri;
        }

        public static T GetSafe<T>(this System.Data.IDataReader dr, int column)
        {
            var o = dr[column];
            if (o == null || o == DBNull.Value)
            {
                return default(T);
            }
            else
            {
                return (T)o;
            }
        }
        public static T GetSafe<T>(this System.Data.IDataReader dr, string column)
        {
            var o = dr[column];
            if (o == null || o == DBNull.Value)
            {
                return default(T);
            }
            else
            {
                return (T)o;
            }
        }

        public static T Get<T>(this System.Data.IDataReader dr, int column)
        {
            var o = dr[column];
            return (T)o;
        }
        public static T Get<T>(this System.Data.IDataReader dr, string column)
        {
            var o = dr[column];
            return (T)o;
        }

        public static bool IsDBNull(this IDataReader dr, string column)
        {
            return dr.IsDBNull(dr.GetOrdinal(column));
        }

        public static bool HasColumn(this IDataReader dr, string column)
        {
            var dv = dr.GetSchemaTable().DefaultView;
            dv.RowFilter = string.Format("ColumnName= '{0}'", column);
            return dv.Count > 0;
        }


        public static HttpResponse Write(this HttpResponse response, params string[] values)
        {
            foreach (var s in values)
            {
                response.Write(s);
            }
            return response;
        }

        public static object DBNullIfNullOrEmpty(this string s)
        {
            if (string.IsNullOrEmpty(s)) return DBNull.Value;
            return s;
        }

        public static object DBNullIfDefault<T>(this T o)
        {
            if (object.Equals(o, default(T))) return DBNull.Value;
            return o;
        }

        public static string NullIfEmpty(this string s)
        {
            if (string.IsNullOrEmpty(s)) return null;
            return s;
        }


        public static int? TryParse(string s)
        {
            int i;
            if (int.TryParse(s, out i))
            {
                return i;
            }
            return null;
        }

        public static string SplitWordsToSentence(this string source)
        {
            return string.Join(" ", SplitWords(source));
        }

        private static string[] SplitWords(this string source)
        {
            if (source == null) return new string[] { }; //Return empty array.
            if (source.Length == 0) return new string[] { "" };

            StringCollection words = new StringCollection();
            int wordStartIndex = 0;
            char[] letters = source.ToCharArray();
            char previousChar = char.MinValue;

            // Skip the first letter. we don't care what case it is.
            for (int i = 1; i < letters.Length; i++)
            {
                if (char.IsUpper(letters[i]) && !char.IsWhiteSpace(previousChar))
                {
                    //Grab everything before the current character.
                    words.Add(new String(letters, wordStartIndex, i - wordStartIndex));
                    wordStartIndex = i;
                }
                previousChar = letters[i];
            }

            //We need to have the last word.
            words.Add(new String(letters, wordStartIndex, letters.Length - wordStartIndex));

            string[] wordArray = new string[words.Count];
            words.CopyTo(wordArray, 0);
            return wordArray;
        }

        public static double InWeeks(this TimeSpan t)
        {
            return t.TotalDays / 7;
        }

        public static double InYears(this TimeSpan t)
        {
            return t.TotalDays / 365;
        }

        public static int MonthsBetween(this DateTime startDate, DateTime endDate)
        {
            DateTime cur = startDate;
            var d = 0;
            for (int i = 0; cur <= endDate; cur = startDate.AddMonths(++i))
            {
                d++;
            }
            return d + 1;
        }



        public static string TruncateAt(this string s, int maxLength)
        {
            if (string.IsNullOrEmpty(s)) return s;
            if (s.Length <= maxLength) return s;

            if (s.Length > 3 && maxLength <= 3) return "...";
            return s.Substring(0, maxLength - 3) + "...";
        }

        public static int FirstIndexOf<T>(this IEnumerable<T> e, Func<T, bool> predicate)
        {
            return e.TakeWhile(predicate).Count() - 1;
        }

        public static string TitleCase(this string s)
        {
            var ti = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo;
            // lowercase to remove any acronyms
            return ti.ToTitleCase(s.ToLower());
        }

        public static string IfNullOrEmpty(this string @this, string s)
        {
            return string.IsNullOrEmpty(@this) ? s : @this;
        }

        public static MvcHtmlString Pager(this HtmlHelper helper, int currentPage, int currentPageSize, int totalRecords)
        {
            if (totalRecords < currentPageSize)
                return null;

            StringBuilder sb = new StringBuilder();
            var uri = HttpContext.Current.Request.Url;

            int seed = currentPage % currentPageSize == 0 ? currentPage : currentPage - (currentPage % currentPageSize);

            if (currentPage > 1)
                sb.AppendLine(String.Format("<a class='page' href=\"{0}\">Previous</a>", uri.AddQueryString("page", currentPage - 1)));

            if (currentPage - currentPageSize >= 0)
                sb.AppendLine(String.Format("<a class='page' href=\"{0}\">...</a>", uri.AddQueryString("page", (currentPage - currentPageSize) + 1)));

            for (int i = seed; i < Math.Ceiling(double.Parse(totalRecords.ToString()) / double.Parse(currentPageSize.ToString())) && i < seed + currentPageSize; i++)
                sb.AppendLine(String.Format("<a href=\"{0}\" class=\"{2}\">{1}</a>", uri.AddQueryString("page", i + 1), i + 1, currentPage == i + 1 ? "page active" : "page"));

            if (currentPage + currentPageSize <= (Math.Ceiling(double.Parse(totalRecords.ToString()) / double.Parse(currentPageSize.ToString()))))
                sb.AppendLine(String.Format("<a class='page' href=\"{0}\" >...</a>", uri.AddQueryString("page", (currentPage + currentPageSize) + 1)));

            if (currentPage < (Math.Ceiling(double.Parse(totalRecords.ToString()) / double.Parse(currentPageSize.ToString()))))
                sb.AppendLine(String.Format("<a class='page' href=\"{0}\">Next</a>", uri.AddQueryString("page", currentPage + 1)));

            return new MvcHtmlString(sb.ToString());
        }

        public static IEnumerable<T> Page<T>(this IEnumerable<T> en, int pageSize, int page)
        {
            return en.Skip((page - 1) * pageSize).Take(pageSize);
        }
        public static IQueryable<T> Page<T>(this IQueryable<T> en, int pageSize, int page)
        {
            return en.Skip((page - 1) * pageSize).Take(pageSize);
        }

        public static void Update<TSource>(this IEnumerable<TSource> outer, Action<TSource> updator)
        {
            foreach (TSource item in outer)
            {
                updator(item);
            }
        }

        public static DataTable ToDataTable<T>(this IEnumerable<T> items)
        {
            // Create the result table, and gather all properties of a T        
            DataTable table = new DataTable(typeof(T).Name);
            PropertyInfo[] props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            // Add the properties as columns to the datatable
            foreach (var prop in props)
            {
                Type propType = prop.PropertyType;

                // Is it a nullable type? Get the underlying type 
                if (propType.IsGenericType && propType.GetGenericTypeDefinition().Equals(typeof(Nullable<>)))
                    propType = new NullableConverter(propType).UnderlyingType;

                table.Columns.Add(prop.Name, propType);
            }

            // Add the property values per T as rows to the datatable
            foreach (var item in items)
            {
                var values = new object[props.Length];
                for (var i = 0; i < props.Length; i++)
                    values[i] = props[i].GetValue(item, null);

                table.Rows.Add(values);
            }

            return table;
        }



        public static IEnumerable<string> ToCsv<T>(this IEnumerable<T> objectlist, string separator)
        {
            FieldInfo[] fields = typeof(T).GetFields();
            PropertyInfo[] properties = typeof(T).GetProperties();
            yield return String.Join(separator, fields.Select(f => f.Name).Union(properties.Select(p => p.Name)).ToArray());
            foreach (var o in objectlist)
            {
                yield return string.Join(separator, fields.Select(f => (f.GetValue(o) ?? "").ToString())
                    .Union(properties.Select(p => (p.GetValue(o, null) ?? "").ToString())).ToArray());
            }
        }

        private static Image ResizeImage(Image imgToResize, Size size)
        {
            int sourceWidth = imgToResize.Width;
            int sourceHeight = imgToResize.Height;

            float nPercent = 0;
            float nPercentW = 0;
            float nPercentH = 0;

            nPercentW = ((float)size.Width / (float)sourceWidth);
            nPercentH = ((float)size.Height / (float)sourceHeight);

            if (nPercentH < nPercentW)
                nPercent = nPercentH;
            else
                nPercent = nPercentW;

            int destWidth = (int)(sourceWidth * nPercent);
            int destHeight = (int)(sourceHeight * nPercent);

            Bitmap b = new Bitmap(destWidth, destHeight);
            Graphics g = Graphics.FromImage((Image)b);
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;

            g.DrawImage(imgToResize, 0, 0, destWidth, destHeight);
            g.Dispose();

            return (Image)b;
        }


    }

    internal class LowerCaseRouteDecorator : RouteBase, IRouteWithArea
    {
        private readonly RouteBase _innerRoute;

        public LowerCaseRouteDecorator(RouteBase innerRoute)
        {
            _innerRoute = innerRoute;
        }

        public RouteBase InnerRoute
        {
            get { return _innerRoute; }
        }

        public override RouteData GetRouteData(HttpContextBase httpContext)
        {
            return _innerRoute.GetRouteData(httpContext);
        }

        public override VirtualPathData GetVirtualPath(RequestContext requestContext, RouteValueDictionary values)
        {
            VirtualPathData path = _innerRoute.GetVirtualPath(requestContext, values);

            if (path != null && path.VirtualPath != null)
            {
                string virtualPath = path.VirtualPath;
                path.VirtualPath = ToLowerVirtualPath(virtualPath);
            }

            return path;
        }

        private static string ToLowerVirtualPath(string virtualPath)
        {
            var lastIndexOf = virtualPath.LastIndexOf("?", StringComparison.OrdinalIgnoreCase);

            if (lastIndexOf < 0)
            {
                return virtualPath.ToLowerInvariant();
            }

            string path = virtualPath.Substring(0, lastIndexOf).ToLowerInvariant();
            string query = virtualPath.Substring(lastIndexOf);
            return path + query;
        }

        public string Area
        {
            get
            {
                string area = GetAreaToken(_innerRoute);
                return area;
            }
        }

        private string GetAreaToken(RouteBase routeBase)
        {
            var route = routeBase as Route;
            if (route == null || route.DataTokens == null)
            {
                return null;
            }
            return route.DataTokens["area"] as string;
        }
    }


    public static class ResizePng
    {
        private static IDictionary<string, ImageFormat> _transparencyFormats = new Dictionary<string, ImageFormat>(StringComparer.OrdinalIgnoreCase) { { "png", ImageFormat.Png }, { "gif", ImageFormat.Gif } };

        public static WebImage ResizePreserveTransparency(this WebImage image, int width, int height)
        {
            ImageFormat format = null;
            if (!_transparencyFormats.TryGetValue(image.ImageFormat, out format))
            {
                return image.Resize(width, height);
            }

            using (Image resizedImage = new Bitmap(width, height))
            {
                using (Bitmap source = new Bitmap(new MemoryStream(image.GetBytes())))
                {
                    using (Graphics g = Graphics.FromImage(resizedImage))
                    {
                        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                        g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                        g.DrawImage(source, 0, 0, width, height);
                    }
                }
                using (MemoryStream ms = new MemoryStream())
                {
                    resizedImage.Save(ms, format);
                    return new WebImage(ms.ToArray());
                }
            }
        }
    }
}
