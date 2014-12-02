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
    public class EnquiryViewModel : Enquiries
    {

        public EnquiryViewModel() { }

        public EnquiryViewModel(Enquiries e)
        {
            this.ActionId = e.ActionId;
            this.EnquiryId = e.EnquiryId;
            this.SourceId = e.SourceId;
            this.EnquiryTypeId = e.EnquiryTypeId;
            this.ContactNumber = e.ContactNumber;
            this.Name = e.Name;
            this.DateOfEnquiry = e.DateOfEnquiry;
            this.Discipline = e.Discipline;
            this.StateId = e.StateId;
            this.CityId = e.CityId;
            this.Address = e.Address;
            this.AttendedBy = e.AttendedBy;
            this.Demo = e.Demo;
            this.RemarksByFaculty = e.RemarksByFaculty;
            this.StatusId = e.StatusId;
            this.ProbableStudentFor = e.ProbableStudentFor;
            this.Gender = e.Gender;
            this.Age = e.Age;
            this.Occupation = e.Occupation;
            this.FinalComments = e.FinalComments;
            this.NoOfClasses = e.NoOfClasses;
            this.Package = e.Package;
            this.RegistrationAmount = e.RegistrationAmount;
            this.CentreId = e.CentreId;
            this.IsEnquiryClosed = e.IsEnquiryClosed;
            this.AddDate = e.AddDate;
            this.AddedBy = e.AddedBy;
            this.ModifyDate = e.ModifyDate;
            this.ModifyBy = e.ModifyBy;
            this.IsActive = e.IsActive;
            this.IsDeleted = e.IsDeleted;

        }

        public override int ActionId { get; set; }
        public override int EnquiryId { get; set; }
        [Required(ErrorMessageResourceType = typeof(Messages), ErrorMessageResourceName = "SourceRequired")]
        public override int SourceId { get; set; }
        public override int EnquiryTypeId { get; set; }
        [Required(ErrorMessageResourceType = typeof(Messages), ErrorMessageResourceName = "ContactNumberRequired")]
        public override string ContactNumber { get; set; }
        [Required(ErrorMessageResourceType = typeof(Messages), ErrorMessageResourceName = "NameRequired")]
        public override string Name { get; set; }
        [Required(ErrorMessageResourceType = typeof(Messages), ErrorMessageResourceName = "DateOfEnquiryRequired")]
        public override DateTime? DateOfEnquiry { get; set; }
        [Required(ErrorMessageResourceType = typeof(Messages), ErrorMessageResourceName = "DisciplineRequired")]
        public override int Discipline { get; set; }
        [Required(ErrorMessageResourceType = typeof(Messages), ErrorMessageResourceName = "StateIdRequired")]
        public override int StateId { get; set; }
        [Required(ErrorMessageResourceType = typeof(Messages), ErrorMessageResourceName = "CityIdRequired")]
        public override int CityId { get; set; }
        [Required(ErrorMessageResourceType = typeof(Messages), ErrorMessageResourceName = "AddressRequired")]
        public override string Address { get; set; }
        [Required(ErrorMessageResourceType = typeof(Messages), ErrorMessageResourceName = "AttendedByRequired")]
        public override int AttendedBy { get; set; }
        public override bool Demo { get; set; }
        public override string RemarksByFaculty { get; set; }
        [Required(ErrorMessageResourceType = typeof(Messages), ErrorMessageResourceName = "StatusIdRequired")]
        public override int StatusId { get; set; }
        public override int ProbableStudentFor { get; set; }
        public override int Gender { get; set; }
        public override int Age { get; set; }
        public override string Occupation { get; set; }
        [Required(ErrorMessageResourceType = typeof(Messages), ErrorMessageResourceName = "RemarksRequired")]
        public override string FinalComments { get; set; }
        public override int NoOfClasses { get; set; }
        public override double Package { get; set; }
        public override double RegistrationAmount { get; set; }
        public override int CentreId { get; set; }
        public override DateTime? AddDate { get; set; }
        public override int AddedBy { get; set; }
        public override DateTime? ModifyDate { get; set; }
        public override int ModifyBy { get; set; }
        public override bool IsActive { get; set; }
        public override bool IsEnquiryClosed { get; set; }
    }
}