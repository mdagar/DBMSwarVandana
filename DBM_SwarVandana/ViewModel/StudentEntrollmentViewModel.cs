using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using DBM_SwarVandana.Resources;

namespace ViewModel
{
    [NotMapped]
    public class StudentEntrollmentViewModel : StudentEnrollment
    {
        public StudentEntrollmentViewModel() { }

        public StudentEntrollmentViewModel(StudentEnrollment se)
        {
            this.EnrollmentId = se.EnrollmentId;
            this.StudentId = se.StudentId;
            this.DisciplineId = se.DisciplineId;            
            this.CourseAmount = se.CourseAmount;
            this.RegistratonAmount = se.RegistratonAmount;
            this.NoOfClasses = se.NoOfClasses;
            this.AmountPaid = se.AmountPaid;
            this.SatrtDate = se.SatrtDate;
            this.EndDate = se.EndDate;
            this.CreatedDate = se.CreatedDate;
            this.CreatedBy = se.CreatedBy;
            this.ModifyDate = se.ModifyDate;
            this.ModifBy = se.ModifBy;
            this.IsActive = se.IsActive;
            this.IsDeleted = se.IsDeleted;
            this.PendingAmount = se.PendingAmount;
            this.Absents = se.Absents;
            this.Presents = se.Presents;
            this.StudentName = se.StudentName;
            this.BankName = se.BankName;
            this.PaymentMode = se.PaymentMode;
            this.PaymentDetails = se.PaymentDetails;
            this.DueDate = se.DueDate;
        }

        public override long EnrollmentId { get; set; }
        public override long StudentId { get; set; }
        [Required(ErrorMessageResourceType = typeof(Messages), ErrorMessageResourceName = "DisplaneSelect")]
        public override long DisciplineId { get; set; }
        [Required(ErrorMessageResourceType = typeof(Messages), ErrorMessageResourceName = "CourseAmount")]
        public override decimal CourseAmount { get; set; }
        public override decimal RegistratonAmount { get; set; }
        [Required(ErrorMessageResourceType = typeof(Messages), ErrorMessageResourceName = "NoofClasses")]
        public override int NoOfClasses { get; set; }
        [Required(ErrorMessageResourceType = typeof(Messages), ErrorMessageResourceName = "AmountPaid")]
        public override decimal AmountPaid { get; set; }
        [Required(ErrorMessageResourceType = typeof(Messages), ErrorMessageResourceName = "StartDateRequired")]
        public override DateTime? SatrtDate { get; set; }
        [Required(ErrorMessageResourceType = typeof(Messages), ErrorMessageResourceName = "EndDateRequired")]
        public override DateTime? EndDate { get; set; }
        public override DateTime? CreatedDate { get; set; }
        public override long CreatedBy { get; set; }
        public override DateTime? ModifyDate { get; set; }
        public override long ModifBy { get; set; }
        public override bool IsActive { get; set; }
        public override bool IsDeleted { get; set; }
        public override decimal PendingAmount { get; set; }
        public override int Absents { get; set; }
        public override int Presents { get; set; }
        public override string StudentName { get; set; }
        [Required(ErrorMessageResourceType = typeof(Messages), ErrorMessageResourceName = "DueDateRequired")]
        public override DateTime? DueDate { get; set; }
    }
}