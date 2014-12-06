using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Models
{
    public class Users
    {
        public virtual int ActionId { get; set; }
        public virtual int UserId { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual DateTime? DOB { get; set; }
        public virtual DateTime? DOJ { get; set; }
        public virtual string ContactNumber { get; set; }
        public virtual string EmailID { get; set; }
        public virtual int CentreId { get; set; }
        public virtual double Salary { get; set; }
        public virtual int RoleId { get; set; }
        public virtual string UserName { get; set; }
        public virtual string Password { get; set; }
        public virtual int StateId { get; set; }
        public virtual int CityId { get; set; }
        public virtual string Address { get; set; }
        public virtual DateTime? AddDate { get; set; }
        public virtual int AddedBy { get; set; }
        public virtual DateTime? ModifyDate { get; set; }
        public virtual int ModifyBy { get; set; }
        public virtual bool IsActive { get; set; }
        public virtual bool IsDeleted { get; set; }
        public virtual string StateName { get; set; }
        public virtual string CityName { get; set; }

        public Users()
        {
            this.UserId = 0;
            this.FirstName = string.Empty;
            this.LastName = string.Empty;
            this.DOB = null;
            this.DOJ = null;
            this.ContactNumber = string.Empty;
            this.EmailID = string.Empty;
            this.CentreId = 0;
            this.Salary = 0;
            this.RoleId = 0;
            this.UserName = string.Empty;
            this.Password = string.Empty;
            this.StateId = 0;
            this.CityId = 0;
            this.Address = string.Empty;
            this.AddDate = null;
            this.AddedBy = 0;
            this.ModifyDate = null;
            this.ModifyBy = 0;
            this.IsActive = true;
            this.IsDeleted = false;

        }

    }
}