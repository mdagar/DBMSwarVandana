using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Models;
using System.ComponentModel.DataAnnotations;
using DBM_SwarVandana.Resources;
using System.ComponentModel.DataAnnotations.Schema;

namespace ViewModel
{
    public class StudentRenewalViewModel : StudentRenewal
    {
        public StudentRenewalViewModel()
        {
        }

        public StudentRenewalViewModel(StudentRenewal sr)
        {
            this.ActionId = sr.ActionId;
            this.FacultyId = sr.FacultyId;
            this.EnrollmentId = sr.EnrollmentId;
            this.StudentId = sr.StudentId;
            this.Description = sr.Description;
            this.Remark = sr.Remark;
            this.Status = sr.Status;
            this.RenewalDate = sr.RenewalDate;
        }

        public override int ActionId { get; set; }
        public override long EnrollmentId { get; set; }
        public override long StudentId { get; set; }
        [Required(ErrorMessageResourceType = typeof(Messages), ErrorMessageResourceName = "FacultyIdRequired")]
        public override Int64 FacultyId { get; set; }
        [Required(ErrorMessageResourceType = typeof(Messages), ErrorMessageResourceName = "DescriptionRequired")]
        public override string Description { get; set; }
        public override string Remark { get; set; }
        public override string Status { get; set; }
        public override DateTime? RenewalDate { get; set; }
    }
}