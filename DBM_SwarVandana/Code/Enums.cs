using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Code
{

    public enum UserRole
    {
        [Description("Admin")]
        User = 1,
        [Description("Center Head")]
        Admin,
        [Description("Super Admin")]
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
        Yellow,
        Blue
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
        Male = 1,
        [Description("Female")]
        Female
    }
    public enum WeekDays
    {

        [Description("Monday")]
        Monday = 1,
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
    public enum AttendenceStatus
    {
        [Description("Present")]
        Present = 1,
        [Description("Absent")]
        Absent,
        [Description("Leave")]
        Leave
    }
    public enum PaymentMode
    {
        [Description("Cash")]
        Cash = 1,
        [Description("Cheque")]
        Cheque,
        [Description("Credit Card")]
        CreditCard,
        [Description("Old Payment")]
        OldPayment
    }

    public enum Months
    {
       
        [Description("April")]
        April = 4,
        [Description("May")]
        May = 5,
        [Description("June")]
        June = 6,
        [Description("July")]
        July = 7,
        [Description("August")]
        August = 8,
        [Description("September")]
        September = 9,
        [Description("October")]
        October = 10,
        [Description("November")]
        November = 11,
        [Description("December")]
        December = 12,
        [Description("January")]
        January = 1,
        [Description("February")]
        February = 2,
        [Description("March")]
        March = 3,
    }

    public enum TargetType
    {
        PE = 1,
        TE,
        Renewal
    }

    public enum Message
    {
        TETOPE = 1,
        Renewal,
        PETOENROLL,
        PaymentPending,
        Enrolled,
        CustomerFeedBack
    }

}