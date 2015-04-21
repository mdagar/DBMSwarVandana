using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Models
{
    public class PaymentDetails
    {
        public virtual long PaymentId { get; set; }
        public virtual long EnrollmentId { get; set; }
        public virtual long StudentId { get; set; }
        public virtual string BankName { get; set; }
        public virtual int PaymentMode { get; set; }
        public virtual string TransactionDetails { get; set; }
        public virtual DateTime? DateOfPayment { get; set; }
        public virtual decimal AmountPaid { get; set; }
        public virtual DateTime? DueDate { get; set; }
        public virtual long AddBy { get; set; }
        public virtual DateTime? AddDate { get; set; }
        public virtual long ModifyBy { get; set; }
        public virtual DateTime? ModifyDate { get; set; }
        public virtual bool IsPendingPayment { get; set; }
        

        public PaymentDetails()
        {
            this.PaymentId = 0;
            this.EnrollmentId = 0;
            this.StudentId = 0;
            this.BankName = string.Empty;
            this.PaymentMode = 0;
            this.TransactionDetails = string.Empty;
            this.DateOfPayment = null;
            this.AmountPaid = 0;
            this.DueDate = null;
            this.AddBy = 0;
            this.AddDate = null;
            this.ModifyBy = 0;
            this.ModifyDate = null;
            this.IsPendingPayment = true;

        }
    }
}