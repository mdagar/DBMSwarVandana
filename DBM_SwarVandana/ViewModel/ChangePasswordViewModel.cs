using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using DBM_SwarVandana.Resources;
using System.ComponentModel.DataAnnotations.Schema;


namespace ViewModel
{
    [NotMapped]
    public class ChangePasswordViewModel
    {
        public virtual int UserId { get; set; }

        [Required(ErrorMessageResourceType = typeof(Messages), ErrorMessageResourceName = "PasswordRequired")]
        public virtual string Password { get; set; }

        [Required(ErrorMessageResourceType = typeof(Messages), ErrorMessageResourceName = "NewPassword")]
        public virtual string NewPassword{get;set;}

        [Required(ErrorMessageResourceType = typeof(Messages), ErrorMessageResourceName = "ConfirmPassword")]
        [Compare("NewPassword", ErrorMessageResourceType = typeof(Messages), ErrorMessageResourceName = "PasswordNotMatched")]
        public virtual string ConfirmPassword { get; set; }
    }
}