using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Models
{
    public class StudentRenewal
    {
        public StudentRenewal()
        {
            this.ActionId = 0;
            this.EnrollmentId = 0;
            this.StudentId = 0;
            this.FacultyId = 0;
            this.Description = string.Empty;
            this.Remark = string.Empty;
            this.Status = string.Empty;
            this.RenewalDate = null;
        }

        public virtual int ActionId { get; set; }
        public virtual long EnrollmentId { get; set; }
        public virtual long StudentId { get; set; }
        public virtual Int64 FacultyId { get; set; }
        public virtual string Description { get; set; }
        public virtual string Remark { get; set; }
        public virtual string Status { get; set; }
        public virtual DateTime? RenewalDate { get; set; }
    }
}