using Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewModel;
using Repositories;
using DBM_SwarVandana.Resources;

namespace DBM_SwarVandana.Controllers
{
    public class ReportController : Controller
    {
        //
        // GET: /Report/

        [Authenticate]
        public ActionResult StudentAttendence()
        {
            return View();
        }

        [Authenticate]
        [HttpPost]
        public ActionResult StudentAttendence(string disciplineId)
        {
            return View();
        }
    }
}
