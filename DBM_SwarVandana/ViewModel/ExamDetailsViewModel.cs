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
    public class ExamDetailsViewModel : ExamDetails
    {
        public ExamDetailsViewModel() { }
        public ExamDetailsViewModel(ExamDetails ed)
        {
            this.ActionID = ed.ActionID;
            this.ExamID = ed.ExamID;
            this.StudentID = ed.StudentID;
            this.ExamName = ed.ExamName;
            this.ExamDate = ed.ExamDate;
            this.FacultyID = ed.FacultyID;
            this.ExamFees = ed.ExamFees;
            this.Comments = ed.Comments;
            this.ResultOfExam = ed.ResultOfExam;
            this.CentreID = ed.CentreID;
            this.CreatedBy = ed.CreatedBy;
            this.CreatedOn = ed.CreatedOn;
            this.ModifiedBy = ed.ModifiedBy;
            this.ModifiedOn = ed.ModifiedOn;
            this.IsActive = ed.IsActive;
            this.IsDeleted = ed.IsDeleted;
        }

        public override Int64 ActionID { get; set; }
        public override Int64 ExamID { get; set; }
        [Required(ErrorMessageResourceType = typeof(Messages), ErrorMessageResourceName = "StudentRequired")]
        public override Int64 StudentID { get; set; }
        [Required(ErrorMessageResourceType = typeof(Messages), ErrorMessageResourceName = "ExamRequired")]
        public override string ExamName { get; set; }
        [Required(ErrorMessageResourceType = typeof(Messages), ErrorMessageResourceName = "ExamDateRequired")]
        public override DateTime? ExamDate { get; set; }
        [Required(ErrorMessageResourceType = typeof(Messages), ErrorMessageResourceName = "FacultyIdRequired")]
        public override Int64 FacultyID { get; set; }
        [Required(ErrorMessageResourceType = typeof(Messages), ErrorMessageResourceName = "ExamFeesRequired")]
        public override decimal ExamFees { get; set; }
        public override string Comments { get; set; }
        public override string ResultOfExam { get; set; }
        public override Int64 CentreID { get; set; }
        public override Int64 CreatedBy { get; set; }
        public override DateTime? CreatedOn { get; set; }
        public override Int64 ModifiedBy { get; set; }
        public override DateTime? ModifiedOn { get; set; }
        public override bool IsActive { get; set; }
        public override bool IsDeleted { get; set; }

    }
}