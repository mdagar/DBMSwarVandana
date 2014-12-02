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
    public class CentresViewModel : Centres
    {
        public CentresViewModel() { }

        public CentresViewModel(Centres c)
        {
            this.CentreId = c.CentreId;
            this.CentreName = c.CentreName;
            this.Address = c.Address;
            this.StateId = c.StateId;
            this.CityId = c.CityId;
            this.CentreOpenDate = c.CentreOpenDate;
            this.AddDate = c.AddDate;
            this.AddedBy = c.AddedBy;
            this.ModifyDate = c.ModifyDate;
            this.ModifyBy = c.ModifyBy;
            this.IsActive = c.IsActive;

        }

        [Required(ErrorMessageResourceType = typeof(Messages), ErrorMessageResourceName = "CentreNameRequired")]
        public override string CentreName { get; set; }

        [Required(ErrorMessageResourceType = typeof(Messages), ErrorMessageResourceName = "AddressRequired")]
        public override string Address { get; set; }

        [Required(ErrorMessageResourceType = typeof(Messages), ErrorMessageResourceName = "StateRequired")]
        public override int StateId { get; set; }

        [Required(ErrorMessageResourceType = typeof(Messages), ErrorMessageResourceName = "CityRequired")]
        public override int CityId { get; set; }

        [Required(ErrorMessageResourceType = typeof(Messages), ErrorMessageResourceName = "CentreOpenDateRequired")]
        public override DateTime? CentreOpenDate { get; set; }
    }
}