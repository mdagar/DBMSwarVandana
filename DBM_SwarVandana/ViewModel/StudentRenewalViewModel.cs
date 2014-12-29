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
            this.RenewalId = sr.RenewalId;
            this.FacultyId = sr.FacultyId;
            this.StudentId = sr.StudentId;
            this.EnrollmentNo = sr.EnrollmentNo;
            this.Description = sr.Description;
            this.Remark = sr.Remark;
            this.Status = sr.Status;
            this.AddDate = sr.AddDate;
            this.CenterId = sr.CenterId;
            this.AddedBy = sr.AddedBy;
            this.ModifyDate = null;
            this.ModifyBy = 0;
        }

        public override int ActionId { get; set; }
        public override long RenewalId { get; set; }
        public override long StudentId { get; set; }
        [Required(ErrorMessageResourceType = typeof(Messages), ErrorMessageResourceName = "FacultyIdRequired")]
        public override Int64 FacultyId { get; set; }
        [Required(ErrorMessageResourceType = typeof(Messages), ErrorMessageResourceName = "DescriptionRequired")]
        public override string Description { get; set; }
        public override string Remark { get; set; }
        public override string Status { get; set; }
        public override DateTime? AddDate { get; set; }
        public override long CenterId { get; set; }
        public override long AddedBy { get; set; }
        public override DateTime? ModifyDate { get; set; }
        public override long ModifyBy { get; set; }
        public override string Name { get; set; }
        public override string Faculty { get; set; }
        public override string EnrollmentNo { get; set; }
    }
}