using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Models
{
    public class StudentRemarks
    {
        public virtual Int64 ActionID { get; set; }
        public virtual Int64 RemarksID { get; set; }
        public virtual Int64 FacultyID { get; set; }
        public virtual Int64 StudentId { get; set; }
        public virtual string Remarks { get; set; }
        public virtual DateTime? DateOfRemarks { get; set; }
        public virtual Int64 CentreID { get; set; }
        public virtual DateTime? CreatedOn { get; set; }
        public virtual Int64 CreatedBy { get; set; }
        public virtual DateTime? ModifiedOn { get; set; }
        public virtual Int64 ModifiedBy { get; set; }
        public virtual bool IsActive { get; set; }
        public virtual bool IsDeleted { get; set; }

        public virtual string FacultyName { get; set; }
        public virtual string StudentName { get; set; }

        public StudentRemarks()
        {
            this.ActionID = 0;
            this.RemarksID = 0;
            this.FacultyID = 0;
            this.StudentId = 0;
            this.Remarks = string.Empty;
            this.DateOfRemarks = null;
            this.CentreID = 0;
            this.CreatedOn = null;
            this.CreatedBy = 0;
            this.ModifiedOn = null;
            this.ModifiedBy = 0;
            this.IsActive = true;
            this.IsDeleted = false;

        }

    }
}