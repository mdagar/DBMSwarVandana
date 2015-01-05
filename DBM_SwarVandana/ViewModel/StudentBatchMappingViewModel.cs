using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ViewModel
{
    public class StudentBatchMappingViewModel : StudentBatchMapping
    {
        public StudentBatchMappingViewModel()
        { }
        public StudentBatchMappingViewModel(StudentBatchMapping s)
        {
            this.ID = s.ID;
            this.StudentId = s.StudentId;
            this.EnrollmentId = s.EnrollmentId;
            this.BatchId = s.BatchId;
            this.CreatedBy = s.CreatedBy;
            this.CreatedDate = s.CreatedDate;
            this.ModifyBy = s.ModifyBy;
            this.ModifyDate = s.ModifyDate;
        }

    }
}