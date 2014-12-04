﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using DBM_SwarVandana.Resources;

namespace ViewModel
{
    public class StudentEntrollmentViewModel : StudentEnrollment
    {
        public StudentEntrollmentViewModel() { }

        public StudentEntrollmentViewModel(StudentEnrollment se)
        {
            this.EnrollmentId = se.EnrollmentId;
            this.StudentId = se.StudentId;
            this.DisciplineId = se.DisciplineId;
            this.ClassId = se.ClassId;
            this.CourseAmount = se.CourseAmount;
            this.RegistratonAmount = se.RegistratonAmount;
            this.NoOfClasses = se.NoOfClasses;
            this.AmountPaid = se.AmountPaid;
            this.SatrtDate = se.SatrtDate;
            this.EndDate = se.EndDate;
            this.CreatedDate = se.CreatedDate;
            this.CreatedBy = se.CreatedBy;
            this.ModifyDate = se.ModifyDate;
            this.ModifBy = se.ModifBy;
        }

        public override long EnrollmentId { get; set; }
        public override long StudentId { get; set; }
        public override long DisciplineId { get; set; }
        public override long ClassId { get; set; }
        public override double CourseAmount { get; set; }
        public override double RegistratonAmount { get; set; }
        public override int NoOfClasses { get; set; }
        public override double AmountPaid { get; set; }
        public override DateTime? SatrtDate { get; set; }
        public override DateTime? EndDate { get; set; }
        public override DateTime? CreatedDate { get; set; }
        public override long CreatedBy { get; set; }
        public override DateTime? ModifyDate { get; set; }
        public override long ModifBy { get; set; }
    }
}