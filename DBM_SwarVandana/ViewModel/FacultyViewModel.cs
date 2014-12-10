using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using DBM_SwarVandana.Resources;

namespace ViewModel
{
    [NotMapped]
    public class FacultyViewModel : Faculties
    {
        public FacultyViewModel() { }

        public FacultyViewModel(Faculties f)
        {
            this.FacultyId = f.FacultyId;
            this.NameOfFaculty = f.NameOfFaculty;
            this.EmailID = f.EmailID;
            this.ContactNumber = f.ContactNumber;
            this.Address = f.Address;
            this.StateId = f.StateId;
            this.CityId = f.CityId;
            this.DOJ = f.DOJ;
            this.DOB = f.DOB;
            this.Gender = f.Gender;
            this.Salary = f.Salary;
            this.SalaryRevision = f.SalaryRevision;
            this.DisciplineId = f.DisciplineId;
            this.YearOfExperience = f.YearOfExperience;
            this.CentreId = f.CentreId;
            this.Picture = f.Picture;
            this.AddDate = f.AddDate;
            this.AddedBy = f.AddedBy;
            this.ModifyDate = f.ModifyDate;
            this.ModifyBy = f.ModifyBy;
            this.IsActive = f.IsActive;
        }

        public override int ActionId { get; set; }
        public override long FacultyId { get; set; }
        [Required(ErrorMessageResourceType = typeof(Messages), ErrorMessageResourceName = "NameRequired")]
        public override string NameOfFaculty { get; set; }
        [Required(ErrorMessageResourceType = typeof(Messages), ErrorMessageResourceName = "EmailIdRequired")]
        public override string EmailID { get; set; }
        [Required(ErrorMessageResourceType = typeof(Messages), ErrorMessageResourceName = "ContactNumberRequired")]
        public override string ContactNumber { get; set; }
        [Required(ErrorMessageResourceType = typeof(Messages), ErrorMessageResourceName = "AddressRequired")]
        public override string Address { get; set; }
        [Required(ErrorMessageResourceType = typeof(Messages), ErrorMessageResourceName = "StateIdRequired")]
        public override int StateId { get; set; }
        [Required(ErrorMessageResourceType = typeof(Messages), ErrorMessageResourceName = "CityIdRequired")]
        public override int CityId { get; set; }
        [Required(ErrorMessageResourceType = typeof(Messages), ErrorMessageResourceName = "DOJRequired")]
        public override DateTime? DOJ { get; set; }
        [Required(ErrorMessageResourceType = typeof(Messages), ErrorMessageResourceName = "DOBRequired")]
        public override DateTime? DOB { get; set; }
        [Required(ErrorMessageResourceType = typeof(Messages), ErrorMessageResourceName = "GenderRequired")]
        public override int Gender { get; set; }
        [Required(ErrorMessageResourceType = typeof(Messages), ErrorMessageResourceName = "SalaryRequired")]
        public override double Salary { get; set; }
        public override double SalaryRevision { get; set; }
        [Required(ErrorMessageResourceType = typeof(Messages), ErrorMessageResourceName = "DisciplineRequired")]
        public override int DisciplineId { get; set; }
        [Required(ErrorMessageResourceType = typeof(Messages), ErrorMessageResourceName = "YearExpRequired")]
        public override int YearOfExperience { get; set; }
        public override int CentreId { get; set; }
        public HttpPostedFileBase Image { get; set; }
        public override DateTime? AddDate { get; set; }
        public override int AddedBy { get; set; }
        public override DateTime? ModifyDate { get; set; }
        public override int ModifyBy { get; set; }
        public override bool IsActive { get; set; }
        
    }
}