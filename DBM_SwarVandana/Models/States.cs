using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Models
{
    public class States
    {
        public int StateId { get; set; }
        public string StateName { get; set; }
        public DateTime AddDate { get; set; }
        public int AddedBy { get; set; }
        public bool IsActive { get; set; }
        public virtual bool IsDeleted { get; set; }
    }
}