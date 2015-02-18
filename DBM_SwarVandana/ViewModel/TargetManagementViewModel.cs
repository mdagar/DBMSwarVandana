using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Models;
using System.Data;
namespace ViewModel
{
    public class TargetManagementViewModel : TargetManagement
    {

        public TargetManagementViewModel()
        {

        }
        public virtual DataSet ds { get; set; }
    }
}