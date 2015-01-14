using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using DBM_SwarVandana.Resources;

namespace ViewModel
{
    public class ReportViewModel
    {
        public ReportViewModel()
        { }
        [Required(ErrorMessageResourceType = typeof(Messages), ErrorMessageResourceName = "EnrollmentNoRequire")]
        public long EnrollmentId { get; set; }
        [Required(ErrorMessageResourceType = typeof(Messages), ErrorMessageResourceName = "DisciplineRequire")]
        public long StudentId { get; set; }
        public long DisciplineId { get; set; }
        public DateTime? DateOfAttendence { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public string AttendenceStatus { get; set; }
        public DataSet ReportDataset { get; set; }
        public DataSet ReportDatasetPayment { get; set; } 
    }
}