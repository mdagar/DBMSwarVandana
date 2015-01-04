using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Models
{
    public class Disciplines
    {
        public virtual int ActionId { get; set; }
        public virtual int DisciplineId { get; set; }
        public virtual string Discipline { get; set; }
        public virtual string Description { get; set; }
        public virtual int CentreID { get; set; }
        public virtual string CentreName { get; set; }
        public virtual DateTime? AddDate { get; set; }
        public virtual int AddedBy { get; set; }
        public virtual DateTime? ModifyDate { get; set; }
        public virtual int ModifyBy { get; set; }
        public virtual bool IsActive { get; set; }
        public virtual bool IsDeleted { get; set; }

        public Disciplines()
        {

            this.DisciplineId = 0;
            this.Discipline = string.Empty;
            this.Description = string.Empty;
            this.CentreID = 0;
            this.CentreName = string.Empty;
            this.AddDate = null;
            this.AddedBy = 0;
            this.ModifyDate = null;
            this.ModifyBy = 0;
            this.IsActive = true;
            this.IsDeleted = false;

        }

    }
}