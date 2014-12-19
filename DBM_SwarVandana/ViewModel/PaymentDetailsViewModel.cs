using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

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
    }
}