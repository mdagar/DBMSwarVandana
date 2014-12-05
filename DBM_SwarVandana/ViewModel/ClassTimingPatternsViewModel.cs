using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ViewModel
{
    public class ClassTimingPatternsViewModel : ClassTimingPatterns
    {
        public ClassTimingPatternsViewModel()
        {
        }

        public ClassTimingPatternsViewModel(ClassTimingPatterns p)
        {
            this.PatternId = p.PatternId;
            this.ClassId = p.ClassId;
            this.WeekDayId = p.WeekDayId;
            this.StartTime = p.StartTime;
            this.EndTime = p.EndTime;
            this.Summary = p.Summary;
            this.AddDate = p.AddDate;
            this.AddedBy = p.AddedBy;
            this.ModifyDate = p.ModifyDate;
            this.ModifyBy = p.ModifyBy;
            this.IsActive = p.IsActive;
        }

        public virtual List<ClassTimingPatterns> li { get; set; }
        public virtual ClassDetails classDetais { get; set; }

    }
}