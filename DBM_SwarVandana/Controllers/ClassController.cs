using Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewModel;
using Repositories;
using DBM_SwarVandana.Resources;
using Models;
using System.Xml;

namespace DBM_SwarVandana.Controllers
{
    public class ClassController : Controller
    {
        //
        // GET: /Class/

        DisciplineRepository _allDiscipline = new DisciplineRepository();
        SourceRepository _allSources = new SourceRepository();
        UsersRepository _allUsers = new UsersRepository();
        FacultyRepository _allFaculty = new FacultyRepository();

        public ActionResult Index()
        {
            return View();
        }

        [Authenticate]
        public ActionResult ClassDetailsList(string Search = "", int page = 1)
        {

            return View();
        }

    }
}
