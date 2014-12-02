using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Models
{
    public class Sources
    {
        public virtual int ActionId { get; set; }
        public virtual int SourceId { get; set; }
        public virtual string Source { get; set; }
        public virtual string Description { get; set; }
        public virtual DateTime? AddDate { get; set; }
        public virtual int AddedBy { get; set; }
        public virtual DateTime? ModifyDate { get; set; }
        public virtual int ModifyBy { get; set; }
        public virtual bool IsActive { get; set; }
        public virtual bool IsDeleted { get; set; }

        public Sources()
        {
            this.SourceId = 0;
            this.Source = string.Empty;
            this.Description = string.Empty;
            this.AddDate = null;
            this.AddedBy = 0;
            this.ModifyDate = null;
            this.ModifyBy = 0;
            this.IsActive = true;
            this.IsDeleted = false;
        }

    }
}