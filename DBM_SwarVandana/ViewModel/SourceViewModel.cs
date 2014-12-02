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
    public class SourceViewModel : Sources
    {
        public SourceViewModel()
        {
        }

        public SourceViewModel(Sources s)
        {
            this.SourceId = s.SourceId;
            this.Source = s.Source;
            this.Description = s.Description;
            this.AddDate = s.AddDate;
            this.AddedBy = s.AddedBy;
            this.ModifyDate = s.ModifyDate;
            this.ModifyBy = s.ModifyBy;
            this.IsActive = s.IsActive;
            this.IsDeleted = false;
        }

        public override int ActionId { get; set; }
        public override int SourceId { get; set; }
        [Required(ErrorMessageResourceType = typeof(Messages), ErrorMessageResourceName = "SourceRequired")]
        public override string Source { get; set; }
        public override string Description { get; set; }
        public override DateTime? AddDate { get; set; }
        public override int AddedBy { get; set; }
        public override DateTime? ModifyDate { get; set; }
        public override int ModifyBy { get; set; }
        public override bool IsActive { get; set; }

    }
}