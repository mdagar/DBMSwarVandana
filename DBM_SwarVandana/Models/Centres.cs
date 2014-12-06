using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Models
{
    public class Centres
    {
        
        public virtual int ActionId { get; set; }
        public virtual int CentreId { get; set; }
        public virtual string CentreName { get; set; }
        public virtual string Address { get; set; }
        public virtual int StateId { get; set; }
        public virtual int CityId { get; set; }
        public virtual DateTime? CentreOpenDate { get; set; }
        public virtual DateTime? AddDate { get; set; }
        public virtual int AddedBy { get; set; }
        public virtual DateTime? ModifyDate { get; set; }
        public virtual int ModifyBy { get; set; }
        public virtual bool IsActive { get; set; }
        public virtual bool IsDeleted { get; set; }
        public virtual  string StateName {get;set;}
        public virtual string CityName { get; set; }

        public Centres() { 
        
           this.CentreId        = 0;
           this.CentreName      = string.Empty;
           this.Address = string.Empty;
           this.StateId         = 0;
           this.CityId          = 0;
           this.CentreOpenDate  = null;
           this.AddDate         = null;
           this.AddedBy         = 0;
           this.ModifyDate      = null;
           this.ModifyBy        = 0;
           this.IsActive        = true;
           this.IsDeleted = false;
        }
    }
}