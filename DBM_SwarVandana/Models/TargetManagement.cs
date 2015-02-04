using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Models
{
    public class TargetManagement
    {
        public virtual long ID { get; set; }
        public virtual int Type { get; set; }
        public virtual int Month { get; set; }
        public virtual string FinancialYear { get; set; }
        public virtual decimal Amount { get; set; }
        public virtual long CenterId { get; set; }
        public virtual long EnqId { get; set; }
        public virtual long CreatedBy { get; set; }
        public virtual DateTime? CreatedDate { get; set; }
        public virtual long ModifyBy { get; set; }
        public virtual DateTime? ModifyDate { get; set; }

        public TargetManagement()
        {
        }
    }
}