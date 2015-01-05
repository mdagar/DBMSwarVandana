using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Models
{
    public class Batches
    {
        public Batches()
        { }

        public virtual long BatchId { get; set; }
        public virtual int Day { get; set; }
        public virtual string Timming { get; set; }
        public virtual int StudentLinit { get; set; }
        public virtual long CreatedBy { get; set; }
        public virtual DateTime? CreatedDate { get; set; }
        public virtual long ModifyBy { get; set; }
        public virtual DateTime? ModifyDate { get; set; }
        public virtual long CenterId { get; set; }

    }
}