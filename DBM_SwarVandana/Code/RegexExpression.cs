using System;
using System.ComponentModel.DataAnnotations;
using System.Web;
using System.Linq;
using System.Collections.Generic;

namespace Code
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter, AllowMultiple = false)]
    public class EmailExpressionAttribute : RegularExpressionAttribute
    {
        public EmailExpressionAttribute()
            : base(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$")
        {
        }
    }
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter, AllowMultiple = false)]
    public class ImageExpressionAttribute : ValidationAttribute
    {
        private readonly List<string> _types;

        public ImageExpressionAttribute()
        {
            _types = (".jpg|.JPG|.jpeg|.JPEG|.gif|.GIF|.png|.PNG").Split('|').ToList();
        }

        public override bool IsValid(object value)
        {
            if (value == null) return true;

            var fileExt = System.IO.Path.GetExtension((value as HttpPostedFileBase).FileName);
            return _types.Contains(fileExt, StringComparer.OrdinalIgnoreCase);
        }

        public override string FormatErrorMessage(string name)
        {
            return string.Format("Invalid file type. Only the following types {0} are supported.", String.Join(", ", _types));
        }
    }

    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter, AllowMultiple = false)]
    public class OnlyAlfaNumericAttribute : RegularExpressionAttribute
    {
        public OnlyAlfaNumericAttribute()
            : base(@"^([a-zA-Z0-9 ]*)$")
        {
        }
    }

    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter, AllowMultiple = false)]
    public class OnlyNumericAttribute : RegularExpressionAttribute
    {
        public OnlyNumericAttribute()
            : base(@"^([0-9]*)$")
        {
        }
    }
    public class NumberlengthOnetoten : RegularExpressionAttribute
    {
        public NumberlengthOnetoten()
            : base(@"\d{1,10}")
        {
        }
    }
}