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
    public class StudentRemarksViewModel : StudentRemarks
    {
        public StudentRemarksViewModel() { }

        public StudentRemarksViewModel(StudentRemarks sr)
        {
            this.ActionID = sr.ActionID;
            this.RemarksID = sr.RemarksID;
            this.FacultyID = sr.FacultyID;
            this.StudentId = sr.StudentId;
            this.Remarks = sr.Remarks;
            this.DateOfRemarks = sr.DateOfRemarks;
            this.CentreID = sr.CentreID;
            this.CreatedOn = sr.CreatedOn;
            this.CreatedBy = sr.CreatedBy;
            this.ModifiedOn = sr.ModifiedOn;
            this.ModifiedBy = sr.ModifiedBy;
            this.IsActive = sr.IsActive;
            this.IsDeleted = sr.IsDeleted;
        }

        public override Int64 ActionID { get; set; }
        public override Int64 RemarksID { get; set; }
        [Required(ErrorMessageResourceType = typeof(Messages), ErrorMessageResourceName = "FacultyIdRequired")]
        public override Int64 FacultyID { get; set; }
        [Required(ErrorMessageResourceType = typeof(Messages), ErrorMessageResourceName = "StatusIdRequired")]
        public override Int64 StudentId { get; set; }
        [Required(ErrorMessageResourceType = typeof(Messages), ErrorMessageResourceName = "RemarksRequired")]
        public override string Remarks { get; set; }
        [Required(ErrorMessageResourceType = typeof(Messages), ErrorMessageResourceName = "RemarksDateRequired")]
        public override DateTime? DateOfRemarks { get; set; }
        public override Int64 CentreID { get; set; }
        public override DateTime? CreatedOn { get; set; }
        public override Int64 CreatedBy { get; set; }
        public override DateTime? ModifiedOn { get; set; }
        public override Int64 ModifiedBy { get; set; }
        public override bool IsActive { get; set; }
        public override bool IsDeleted { get; set; }
    }
}