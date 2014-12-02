using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Models;
using System.ComponentModel.DataAnnotations;
using DBM_SwarVandana.Resources;
using System.ComponentModel.DataAnnotations.Schema;

namespace ViewModel
{
    [NotMapped]
    public class ClassDetailViewModel : ClassDetails
    {
        public ClassDetailViewModel()
        {
        }

        public ClassDetailViewModel(ClassDetails cl)
        {
            this.ActionId = cl.ActionId;
            this.ClassId = cl.ClassId;
            this.DisciplineId = cl.DisciplineId;
            this.FacultyId = cl.FacultyId;
            this.StartDate = cl.StartDate;
            this.EndDate = cl.EndDate;
            this.CentreId = cl.CentreId;
            this.AddDate = cl.AddDate;
            this.AddedBy = cl.AddedBy;
            this.ModifyDate = cl.ModifyDate;
            this.ModifyBy = cl.ModifyBy;
            this.IsActive = cl.IsActive;

        }

        public override int ActionId { get; set; }
        public override Int64 ClassId { get; set; }
        [Required(ErrorMessageResourceType = typeof(Messages), ErrorMessageResourceName = "DisciplineRequired")]
        public override int DisciplineId { get; set; }
        [Required(ErrorMessageResourceType = typeof(Messages), ErrorMessageResourceName = "FacultyIdRequired")]
        public override Int64 FacultyId { get; set; }
        [Required(ErrorMessageResourceType = typeof(Messages), ErrorMessageResourceName = "StartDateRequired")]
        public override DateTime? StartDate { get; set; }
        [Required(ErrorMessageResourceType = typeof(Messages), ErrorMessageResourceName = "EndDateRequired")]
        public override DateTime? EndDate { get; set; }
        public override int CentreId { get; set; }
        public override DateTime? AddDate { get; set; }
        public override int AddedBy { get; set; }
        public override DateTime? ModifyDate { get; set; }
        public override int ModifyBy { get; set; }
        public override bool IsActive { get; set; }
    }
}