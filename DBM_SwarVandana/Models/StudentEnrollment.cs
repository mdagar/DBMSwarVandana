using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Models
{
    public class StudentEnrollment
    {
        public StudentEnrollment()
        {
            this.EnrollmentId = 0;
            this.StudentId = 0;
            this.ClassId = 0;
            this.CourseAmount = 0;
            this.RegistratonAmount = 0;
            this.NoOfClasses = 0;
            this.AmountPaid = 0;
            this.SatrtDate = null;
            this.EndDate = null;
            this.CreatedDate = null;
            this.CreatedBy = 0;
            this.ModifyDate = null;
            this.ModifBy = 0;
        }

        public virtual long EnrollmentId { get; set; }
        public virtual long StudentId { get; set; }
        public virtual long ClassId { get; set; }
        public virtual double CourseAmount { get; set; }
        public virtual double RegistratonAmount { get; set; }
        public virtual int NoOfClasses { get; set; }
        public virtual double AmountPaid { get; set; }
        public virtual DateTime? SatrtDate { get; set; }
        public virtual DateTime? EndDate { get; set; }
        public virtual DateTime? CreatedDate { get; set; }
        public virtual long CreatedBy { get; set; }
        public virtual DateTime? ModifyDate { get; set; }
        public virtual long ModifBy { get; set; }

    }
}