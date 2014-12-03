using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Models
{
    public class ClassDetails
    {
        public virtual int ActionId { get; set; }
        public virtual Int64 ClassId { get; set; }
        public virtual int DisciplineId { get; set; }
        public virtual int StudentLimit { get; set; }        
        public virtual Int64 FacultyId { get; set; }
        public virtual DateTime? StartDate { get; set; }
        public virtual DateTime? EndDate { get; set; }
        public virtual int CentreId { get; set; }
        public virtual DateTime? AddDate { get; set; }
        public virtual int AddedBy { get; set; }
        public virtual DateTime? ModifyDate { get; set; }
        public virtual int ModifyBy { get; set; }
        public virtual bool IsActive { get; set; }
        public virtual bool IsDeleted { get; set; }

        public ClassDetails()
        {
           this.ClassId        =0; 
           this.DisciplineId   =0;
           this.FacultyId      =0;
           this.StudentLimit   =0;
           this.StartDate      =null;
           this.EndDate        =null;
           this.CentreId       =0;
           this.AddDate        =null;
           this.AddedBy        =0;
           this.ModifyDate     =null;
           this.ModifyBy       =0;
           this.IsActive       =true;
           this.IsDeleted = false;
        }

    }
}