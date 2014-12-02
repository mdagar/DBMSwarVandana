using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Models;
using DBM_SwarVandana.Resources;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace ViewModel
{
    [NotMapped]
    public class UsersViewModel : Users
    {
        public UsersViewModel()
        {
        }

        public UsersViewModel(Users u)
        {
            this.ActionId = u.ActionId;
            this.UserId = u.UserId;
            this.FirstName = u.FirstName;
            this.LastName = u.LastName;
            this.DOB = u.DOB;
            this.DOJ = u.DOJ;
            this.ContactNumber = u.ContactNumber;
            this.EmailID = u.EmailID;
            this.CentreId = u.CentreId;
            this.Salary = u.Salary;
            this.RoleId = u.RoleId;
            this.UserName = u.UserName;
            this.Password = u.Password;
            this.StateId = u.StateId;
            this.CityId = u.CityId;
            this.Address = u.Address;
            this.AddDate = u.AddDate;
            this.AddedBy = u.AddedBy;
            this.ModifyDate = u.ModifyDate;
            this.ModifyBy = u.ModifyBy;
            this.IsActive = u.IsActive;

        }

        [Required(ErrorMessageResourceType = typeof(Messages), ErrorMessageResourceName = "UserNameRequired")]
        public override string UserName { get; set; }

        [Required(ErrorMessageResourceType = typeof(Messages), ErrorMessageResourceName = "PasswordRequired")]
        public override string Password { get; set; }

        public override int ActionId { get; set; }
        public override int UserId { get; set; }
       // [Required(ErrorMessageResourceType = typeof(Messages), ErrorMessageResourceName = "FNameRequired")]
        public override string FirstName { get; set; }
       // [Required(ErrorMessageResourceType = typeof(Messages), ErrorMessageResourceName = "LNameRequired")]
        public override string LastName { get; set; }
        public override DateTime? DOB { get; set; }
       // [Required(ErrorMessageResourceType = typeof(Messages), ErrorMessageResourceName = "DOJRequired")]
        public override DateTime? DOJ { get; set; }
        public override string ContactNumber { get; set; }
      //  [Required(ErrorMessageResourceType = typeof(Messages), ErrorMessageResourceName = "EmailIdRequired")]
        public override string EmailID { get; set; }
      //  [Required(ErrorMessageResourceType = typeof(Messages), ErrorMessageResourceName = "CentreIdRequired")]
        public override int CentreId { get; set; }
        public override double Salary { get; set; }
      //  [Required(ErrorMessageResourceType = typeof(Messages), ErrorMessageResourceName = "RoleIdRequired")]
        public override int RoleId { get; set; }
      //  [Required(ErrorMessageResourceType = typeof(Messages), ErrorMessageResourceName = "StateIdRequired")]
        public override int StateId { get; set; }
      //  [Required(ErrorMessageResourceType = typeof(Messages), ErrorMessageResourceName = "CityIdRequired")]
        public override int CityId { get; set; }
        public override string Address { get; set; }
        public override DateTime? AddDate { get; set; }
        public override int AddedBy { get; set; }
        public override DateTime? ModifyDate { get; set; }
        public override int ModifyBy { get; set; }
        public override bool IsActive { get; set; }
       
    }
}