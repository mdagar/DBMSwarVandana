using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Models
{
    public class StudentAttendence
    {
        public StudentAttendence()
        {
            this.Id = 0;
            this.BatchId = 0;
            this.EnrollmentId = 0;
            this.StuentId = 0;
            this.AttendenceStatus = 0;
            this.DateOfAttendence = null;
            this.AddDate = null;
            this.AddBy = 0;
            this.ModifyDate = null;
            this.ModifyBy = 0;
        }

        public virtual long Id { get; set; }
        public virtual long BatchId { get; set; }
        public virtual long DisciplaneId { get; set; }
        public virtual long EnrollmentId { get; set; }
        public virtual long StuentId { get; set; }
        public virtual int AttendenceStatus { get; set; }
        public virtual DateTime? DateOfAttendence { get; set; }
        public virtual DateTime? AddDate { get; set; }
        public virtual long AddBy { get; set; }
        public virtual DateTime? ModifyDate { get; set; }
        public virtual long ModifyBy { get; set; }

    }
}