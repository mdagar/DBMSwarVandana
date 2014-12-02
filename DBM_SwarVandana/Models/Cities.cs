using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Models
{
    public class Cities
    {
        public int CityId { get; set; }
        public int StateId { get; set; }
        public string CityName { get; set; }
        public DateTime AddDate { get; set; }
        public int AddedBy { get; set; }
        public bool IsActive { get; set; }

    }
}