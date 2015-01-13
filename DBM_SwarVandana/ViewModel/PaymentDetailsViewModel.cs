using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using DBM_SwarVandana.Resources;

namespace ViewModel
{
    public class PaymentDetailsViewModel : PaymentDetails
    {
        public PaymentDetailsViewModel()
        {}

        public PaymentDetailsViewModel(PaymentDetails p)
        {
            this.PaymentId = p.PaymentId;
            this.EnrollmentId = p.EnrollmentId;
            this.StudentId = p.StudentId;
            this.BankName = p.BankName;
            this.PaymentMode = p.PaymentMode;
            this.TransactionDetails = p.TransactionDetails;
            this.DateOfPayment = p.DateOfPayment;
            this.AmountPaid = p.AmountPaid;
            this.DueDate = p.DueDate;
            this.AddBy = p.AddBy;
            this.AddDate = p.AddDate;
            this.ModifyBy = p.ModifyBy;
            this.ModifyDate = p.ModifyDate;
        }

        public override Int64 PaymentId { get; set; }
        public override Int64 EnrollmentId { get; set; }
        public override Int64 StudentId { get; set; }
        [Required(ErrorMessageResourceType = typeof(Messages), ErrorMessageResourceName = "BankNameRequire")]
        public override string BankName { get; set; }
        [Required(ErrorMessageResourceType = typeof(Messages), ErrorMessageResourceName = "TransactionDetailsRequired")]
        public override string TransactionDetails { get; set; }
        [Required(ErrorMessageResourceType = typeof(Messages), ErrorMessageResourceName = "DateOfPaymentRequired")]
        public override DateTime? DateOfPayment { get; set; }
        [Required(ErrorMessageResourceType = typeof(Messages), ErrorMessageResourceName = "EnterAmount")]
        public override Decimal AmountPaid { get; set; }
        [Required(ErrorMessageResourceType = typeof(Messages), ErrorMessageResourceName = "DueDateRequired")]
        public override DateTime? DueDate { get; set; }
        public override Int64 AddBy { get; set; }
        public override DateTime? AddDate { get; set; }
        public override Int64 ModifyBy { get; set; }
        public override DateTime? ModifyDate { get; set; }
    }
}