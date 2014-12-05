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
            this.Id = s.Id;
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

        public override int Id { get; set; }
        public override int ActionId { get; set; }
        public override string UniqueKey { get; set; }
        public override string Name { get; set; }
        public override int CenterId { get; set; }
        public override DateTime? DOB { get; set; }
        public override string Contact1 { get; set; }
        public override string Contact2 { get; set; }
        public override string EmailAddress { get; set; }
        public override int StateId { get; set; }
        public override int CityId { get; set; }
        public override string Address { get; set; }
        public override string GuardianName { get; set; }
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