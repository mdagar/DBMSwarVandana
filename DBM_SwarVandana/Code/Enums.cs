using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Code
{

    public enum UserRole
    {
        [Description("Normal User")]
        User = 1,
        [Description("Center Admin")]
        Admin,
        [Description("System Admin")]
        SuperAdmin
    }

    public enum EnquiryType
    {
        [Description("Physical Enquiry")]
        PE = 1,
        [Description("Telephonic Enquiry")]
        TE
    }

    public enum Status
    {
        Red = 1,
        Green,
        Yellow
    }

    public enum EnquiryFor
    {
        Self = 1,
        Child,
        Relative
    }

    public enum Gender
    {
        [Description("Male")]
        Male=1,
        [Description("Female")]
        Female
    }
    public enum WeekDays
    {
        [Description("Monday")]
        Monday=1,
        [Description("Tuesday")]
        Tuesday,
        [Description("Wednesday")]
        Wednesday,
        [Description("Thursday")]
        Thursday,
        [Description("Friday")]
        Friday,
        [Description("Saturday")]
        Saturday,
        [Description("Sunday")]
        Sunday
    }

}