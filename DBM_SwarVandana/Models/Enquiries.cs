﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Models
{
    public class Enquiries
    {
        public virtual int ActionId { get; set; }
        public virtual int EnquiryId { get; set; }
        public virtual int SourceId { get; set; }
        public virtual int EnquiryTypeId { get; set; }
        public virtual string ContactNumber { get; set; }
        public virtual string Name { get; set; }
        public virtual DateTime? DateOfEnquiry { get; set; }
        public virtual int Discipline { get; set; }
        public virtual int StateId { get; set; }
        public virtual int CityId { get; set; }
        public virtual string Address { get; set; }
        public virtual int AttendedBy { get; set; }
        public virtual bool Demo { get; set; }
        public virtual string RemarksByFaculty { get; set; }
        public virtual int StatusId { get; set; }
        public virtual int ProbableStudentFor { get; set; }
        public virtual int Gender { get; set; }
        public virtual int Age { get; set; }
        public virtual string Occupation { get; set; }
        public virtual string FinalComments { get; set; }
        public virtual int NoOfClasses { get; set; }
        public virtual double Package { get; set; }
        public virtual double RegistrationAmount { get; set; }
        public virtual int CentreId { get; set; }
        public virtual DateTime? AddDate { get; set; }
        public virtual int AddedBy { get; set; }
        public virtual DateTime? ModifyDate { get; set; }
        public virtual int ModifyBy { get; set; }
        public virtual bool IsActive { get; set; }
        public virtual bool IsEnquiryClosed { get; set; }
        public virtual bool IsDeleted { get; set; }

        public Enquiries()
        {

            this.EnquiryId = 0;
            this.SourceId = 0;
            this.EnquiryTypeId = 0;
            this.ContactNumber = string.Empty;
            this.Name = string.Empty;
            this.DateOfEnquiry = null;
            this.Discipline = 0;
            this.StateId = 0;
            this.CityId = 0;
            this.Address = string.Empty;
            this.AttendedBy = 0;
            this.Demo = false;
            this.RemarksByFaculty = string.Empty;
            this.StatusId = 0;
            this.ProbableStudentFor = 0;
            this.Gender = 0;
            this.Age = 0;
            this.Occupation = string.Empty;
            this.FinalComments = string.Empty;
            this.NoOfClasses = 0;
            this.Package = 0;
            this.RegistrationAmount = 0;
            this.CentreId = 0;
            this.IsEnquiryClosed = false;
            this.AddDate = null;
            this.AddedBy = 0;
            this.ModifyDate = null;
            this.ModifyBy = 0;
            this.IsActive = true;
            this.IsDeleted = false;

        }

    }
}