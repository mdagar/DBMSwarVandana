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
            this.ActionId = 0;
            this.EnrollmentId = 0;
            this.StudentId = 0;
            this.DisciplineId = 0;            
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
            this.IsActive = true;
            this.IsDeleted = false;
            this.DueDate = null;
            this.EnqueryNo = string.Empty;
            this.IsRenewal = false;
            this.Remark = string.Empty;
        }

        public virtual int ActionId { get; set; }
        public virtual long EnrollmentId { get; set; }
        public virtual long StudentId { get; set; }
        public virtual long DisciplineId { get; set; }        
        public virtual decimal CourseAmount { get; set; }
        public virtual decimal RegistratonAmount { get; set; }
        public virtual int NoOfClasses { get; set; }
        public virtual decimal AmountPaid { get; set; }
        public virtual DateTime? SatrtDate { get; set; }
        public virtual DateTime? EndDate { get; set; }
        public virtual DateTime? CreatedDate { get; set; }
        public virtual long CreatedBy { get; set; }
        public virtual DateTime? ModifyDate { get; set; }
        public virtual long ModifBy { get; set; }
        public virtual bool IsActive { get; set; }
        public virtual bool IsDeleted { get; set; }
        public virtual decimal PendingAmount { get; set; }
        public virtual int Absents { get; set; }
        public virtual int Presents { get; set; }
        public virtual int PaymentMode { get; set; }
        public virtual string BankName { get; set; }
        public virtual string PaymentDetails { get; set; }
        public virtual string DisciplaneName { get; set; }
        public virtual string ClassName { get; set; }
        public virtual string StudentName { get; set; }
        public virtual DateTime? DueDate { get; set; }
        public virtual string EnqueryNo { get; set; }
        public virtual bool IsRenewal { get; set; }
        public virtual string Remark { get; set; }
    }
}