using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Models
{
    public class StudentBatchMapping
    {
        public StudentBatchMapping()
        {
        }
        public virtual long ID { get; set; }
        public virtual long StudentId { get; set; }
        public virtual long EnrollmentId { get; set; }
        public virtual long BatchId { get; set; }
        public virtual long CreatedBy { get; set; }
        public virtual long CreatedDate { get; set; }
        public virtual long ModifyBy { get; set; }
        public virtual long ModifyDate { get; set; }
    }
}