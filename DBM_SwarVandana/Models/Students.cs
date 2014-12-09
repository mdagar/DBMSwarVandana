using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Models
{
    public class Students
    {
        public Students()
        {
            this.StudentId = 0;
            this.ActionId = 0;
            this.UniqueKey = string.Empty;
            this.Name = string.Empty;
            this.CenterId = 0;
            this.DOB = null;
            this.Contact1 = string.Empty;
            this.Contact2 = string.Empty;
            this.EmailAddress = string.Empty;
            this.StateId = 0;
            this.CityId = 0;
            this.Address = string.Empty;
            this.GuardianName = string.Empty;
            this.Occupation = string.Empty;
            this.HasTransportFacility = false;
            this.IsActive = false;
            this.CreatedBy = 0;
            this.CreatedDate = null;
            this.ModifyBy = 0;
            this.ModifyDate = null;
            this.IsDeleted = false;
            
        }

        public virtual long StudentId { get; set; }
        public virtual int ActionId { get; set; }
        public virtual string UniqueKey { get; set; }
        public virtual string Name { get; set; }
        public virtual int CenterId { get; set; }
        public virtual DateTime? DOB { get; set; }
        public virtual string Contact1 { get; set; }
        public virtual string Contact2 { get; set; }
        public virtual string EmailAddress { get; set; }
        public virtual int StateId { get; set; }
        public virtual int CityId { get; set; }
        public virtual string Address { get; set; }
        public virtual string GuardianName { get; set; }
        public virtual string Occupation { get; set; }
        public virtual bool HasTransportFacility { get; set; }
        public virtual bool IsActive { get; set; }
        public virtual int CreatedBy { get; set; }
        public virtual DateTime? CreatedDate { get; set; }
        public virtual int ModifyBy { get; set; }
        public virtual DateTime? ModifyDate { get; set; }
        public virtual bool IsDeleted { get; set; }
    }
}