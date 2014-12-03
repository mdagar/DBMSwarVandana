using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Models
{
    public class ClassTimingPatterns
    {
        public ClassTimingPatterns()
        {
            this.PatternId = 0;
            this.ClassId = 0;
            this.WeekDayId = 0;
            this.StartTime = string.Empty;
            this.EndTime = string.Empty;
            this.Summary = string.Empty;
            this.AddDate = null;
            this.AddedBy = 0;
            this.ModifyDate = null;
            this.ModifyBy = 0;
            this.IsActive = false;
        }

        public virtual long PatternId { get; set; }
        public virtual long ClassId { get; set; }
        public virtual int WeekDayId { get; set; }
        public virtual string StartTime { get; set; }
        public virtual string EndTime { get; set; }
        public virtual string Summary { get; set; }
        public virtual DateTime? AddDate { get; set; }
        public virtual long AddedBy { get; set; }
        public virtual DateTime? ModifyDate { get; set; }
        public virtual long ModifyBy { get; set; }
        public virtual bool IsActive { get; set; }

    }
}