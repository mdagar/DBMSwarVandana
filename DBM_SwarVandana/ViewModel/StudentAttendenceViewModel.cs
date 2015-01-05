using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ViewModel
{
    public class StudentAttendenceViewModel : StudentAttendence
    {
        public StudentAttendenceViewModel()
        { }

        public StudentAttendenceViewModel(StudentAttendence s)
        {
            this.Id = s.Id;
            this.ClassId = s.ClassId;
            this.WeekDayId = s.WeekDayId;
            this.StuentId = s.StuentId;
            this.AttendenceStatus = s.AttendenceStatus;
            this.DateOfAttendence = s.DateOfAttendence;
            this.AddDate = s.AddDate;
            this.AddBy = s.AddBy;
            this.ModifyDate = s.ModifyDate;
            this.ModifyBy = s.ModifyBy;
        }

        public IEnumerable<Students> students { get; set; }        
        public List<StudentAttendence> studentAttendence { get; set; }
    }
}