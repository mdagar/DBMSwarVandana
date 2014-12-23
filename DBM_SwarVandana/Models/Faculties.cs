using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Models
{
    public class Faculties
    {
        public virtual int ActionId { get; set; }
        public virtual long FacultyId { get; set; }
        public virtual string NameOfFaculty { get; set; }
        public virtual string EmailID { get; set; }
        public virtual string ContactNumber { get; set; }
        public virtual string Address { get; set; }
        public virtual int StateId { get; set; }
        public virtual int CityId { get; set; }
        public virtual DateTime? DOJ { get; set; }
        public virtual int Gender { get; set; }
        public virtual decimal Salary { get; set; }
        public virtual decimal SalaryRevision { get; set; }
        public virtual int DisciplineId { get; set; }
        public virtual int YearOfExperience { get; set; }
        public virtual int CentreId { get; set; }
        public virtual string Picture { get; set; }
        public virtual DateTime? AddDate { get; set; }
        public virtual int AddedBy { get; set; }
        public virtual DateTime? ModifyDate { get; set; }
        public virtual int ModifyBy { get; set; }
        public virtual bool IsActive { get; set; }
        public virtual bool IsDeleted { get; set; }
        public virtual DateTime? DOB { get; set; }
        public virtual string DisciplaneName { get; set; }
        public virtual string StateName { get; set; }
        public virtual string CityName { get; set; }

        public Faculties()
        {
            this.FacultyId = 0;
            this.NameOfFaculty = string.Empty;
            this.EmailID = string.Empty;
            this.ContactNumber = string.Empty;
            this.Address = string.Empty;
            this.StateId = 0;
            this.CityId = 0;
            this.DOJ = null;
            this.Gender = 0;
            this.Salary = 0;
            this.SalaryRevision = 0;
            this.DisciplineId = 0;
            this.YearOfExperience = 0;
            this.CentreId = 0;
            this.Picture = string.Empty;
            this.AddDate = null;
            this.AddedBy = 0;
            this.ModifyDate = null;
            this.ModifyBy = 0;
            this.IsActive = true;
            this.IsDeleted = false;
            this.DOB = null;
            this.StateName = string.Empty;
            this.CityName = string.Empty;
        }

    }
}