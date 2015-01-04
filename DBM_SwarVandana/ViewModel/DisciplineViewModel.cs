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
    public class DisciplineViewModel : Disciplines
    {
        public DisciplineViewModel() { }

        public DisciplineViewModel(Disciplines d)
        {
            this.ActionId = d.ActionId;
            this.DisciplineId = d.DisciplineId;
            this.Discipline = d.Discipline;
            this.Description = d.Description;
            this.CentreID = d.CentreID;
            this.AddDate = d.AddDate;
            this.AddedBy = d.AddedBy;
            this.ModifyDate = d.ModifyDate;
            this.ModifyBy = d.ModifyBy;
            this.IsActive = d.IsActive;
            this.IsDeleted = d.IsDeleted;
        }

        public override int ActionId { get; set; }
        public override int DisciplineId { get; set; }
        [Required(ErrorMessageResourceType = typeof(Messages), ErrorMessageResourceName = "DisciplineRequired")]
        public override string Discipline { get; set; }
        public override string Description { get; set; }
        public override int CentreID { get; set; }
       
        public override DateTime? AddDate { get; set; }
        public override int AddedBy { get; set; }
        public override DateTime? ModifyDate { get; set; }
        public override int ModifyBy { get; set; }
        public override bool IsActive { get; set; }
    }
}