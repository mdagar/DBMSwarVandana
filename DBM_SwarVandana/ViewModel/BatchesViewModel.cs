using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ViewModel
{
    public class BatchesViewModel : Batches
    {
        public BatchesViewModel()
        { }

        public BatchesViewModel(Batches b)
        {
            this.BatchId = b.BatchId;
            this.Day = b.Day;
            this.Timming = b.Timming;
            this.StudentLinit = b.StudentLinit;
            this.CreatedBy = b.CreatedBy;
            this.CreatedDate = b.CreatedDate;
            this.ModifyBy = b.ModifyBy;
            this.ModifyDate = b.ModifyDate;
        }
    }
}