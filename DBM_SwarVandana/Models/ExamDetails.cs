using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Models
{
    public class ExamDetails
    {

        public virtual Int64 ActionID { get; set; }
        public virtual Int64 ExamID { get; set; }
        public virtual Int64 StudentID { get; set; }
        public virtual string ExamName { get; set; }
        public virtual DateTime? ExamDate { get; set; }
        public virtual Int64 FacultyID { get; set; }
        public virtual decimal ExamFees { get; set; }
        public virtual string Comments { get; set; }
        public virtual string ResultOfExam { get; set; }
        public virtual Int64 CentreID { get; set; }
        public virtual Int64 CreatedBy { get; set; }
        public virtual DateTime? CreatedOn { get; set; }
        public virtual Int64 ModifiedBy { get; set; }
        public virtual DateTime? ModifiedOn { get; set; }
        public virtual bool IsActive { get; set; }
        public virtual bool IsDeleted { get; set; }

        public virtual string FacultyName { get; set; }
        public virtual string StudentName { get; set; }


        public ExamDetails()
        {
            this.ActionID = 0;
            this.ExamID = 0;
            this.StudentID = 0;
            this.ExamName = string.Empty;
            this.ExamDate = null;
            this.FacultyID = 0;
            this.ExamFees = 0;
            this.Comments = string.Empty;
            this.ResultOfExam = null;
            this.CentreID = 0;
            this.CreatedBy = 0;
            this.CreatedOn = null;
            this.ModifiedBy = 0;
            this.ModifiedOn = null;
            this.IsActive = true;
            this.IsDeleted = false;

        }


    }
}