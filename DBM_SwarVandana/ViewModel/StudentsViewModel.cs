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
    public class StudentsViewModel : Students
    {
        public StudentsViewModel() { }
        public StudentsViewModel(Students s)
        {
            this.StudentId = s.StudentId;
            this.ActionId = s.ActionId;
            this.UniqueKey = s.UniqueKey;
            this.Name = s.Name;
            this.CenterId = s.CenterId;
            this.DOB = s.DOB;
            this.Contact1 = s.Contact1;
            this.Contact2 = s.Contact2;
            this.EmailAddress = s.EmailAddress;
            this.StateId = s.StateId;
            this.CityId = s.CityId;
            this.Address = s.Address;
            this.GuardianName = s.GuardianName;
            this.Occupation = s.Occupation;
            this.HasTransportFacility = s.HasTransportFacility;
            this.IsActive = s.IsActive;
            this.CreatedBy = s.CreatedBy;
            this.CreatedDate = s.CreatedDate;
            this.ModifyBy = s.ModifyBy;
            this.ModifyDate = s.ModifyDate;
            this.IsDeleted = s.IsDeleted;
        }




        public override long StudentId { get; set; }
        public override int ActionId { get; set; }
        public override string UniqueKey { get; set; }
        [Required(ErrorMessageResourceType = typeof(Messages), ErrorMessageResourceName = "NameRequired")]
        public override string Name { get; set; }
        public override int CenterId { get; set; }
        public override DateTime? DOB { get; set; }
        [Required(ErrorMessageResourceType = typeof(Messages), ErrorMessageResourceName = "ContactNumberRequired")]
        public override string Contact1 { get; set; }
        public override string Contact2 { get; set; }
        [Required(ErrorMessageResourceType = typeof(Messages), ErrorMessageResourceName = "EmailIdRequired")]
        //[RegularExpression(@"[-0-9a-zA-Z.+_]+@[-0-9a-zA-Z.+_]+\.[a-zA-Z]{2,4}", ErrorMessageResourceType = typeof(Messages), ErrorMessageResourceName = "InvalidEmailAddress")]
        [RegularExpression(@"[-0-9a-zA-Z.+_]+@[-0-9a-zA-Z.+_]+\.[a-zA-Z]{2,4}", ErrorMessage = "Please enter a valid email address")]
        public override string EmailAddress { get; set; }
        [Required(ErrorMessageResourceType = typeof(Messages), ErrorMessageResourceName = "StateRequired")]
        public override int StateId { get; set; }
        [Required(ErrorMessageResourceType = typeof(Messages), ErrorMessageResourceName = "CityIdRequired")]
        public override int CityId { get; set; }
        [Required(ErrorMessageResourceType = typeof(Messages), ErrorMessageResourceName = "AddressRequired")]
        public override string Address { get; set; }
        [Required(ErrorMessageResourceType = typeof(Messages), ErrorMessageResourceName = "GuardianNameRequired")]
        public override string GuardianName { get; set; }
        [Required(ErrorMessageResourceType = typeof(Messages), ErrorMessageResourceName = "Occupationrequired")]
        public override string Occupation { get; set; }
        public override bool HasTransportFacility { get; set; }
        public override bool IsActive { get; set; }
        public override int CreatedBy { get; set; }
        public override DateTime? CreatedDate { get; set; }
        public override int ModifyBy { get; set; }
        public override DateTime? ModifyDate { get; set; }
        public override bool IsDeleted { get; set; }



    }
}