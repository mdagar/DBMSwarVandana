using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Models;

namespace ViewModel
{
    public class StudentBatchDetailsViewModel
    {
        public StudentBatchDetailsViewModel()
        { }
        public List<Batches> allbatch;
        public List<int> selectbatch;
    }
}