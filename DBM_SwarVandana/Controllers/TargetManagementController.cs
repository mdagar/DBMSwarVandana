﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Code;
using Models;
using Repositories;

namespace DBM_SwarVandana.Controllers
{
    public class TargetManagementController : Controller
    {
        //
        // GET: /TargetManagement/

        AllTargetManagement _allAarget = new AllTargetManagement();

        public ActionResult Index()
        {
            return View();
        }

        [Authenticate]
        public ActionResult AddToAgtget()
        {
            return View();
        }

        public string CurrentFinancialYear()
        {
            DateTime date = DateTime.Now;
            string year = "";
            if (date.Month >= 4)
                year = (date.Year + " - " + date.AddYears(1).Year);
            else
                year = date.AddYears(-1).Year + " - " + date.Year;
            return year;
        }

        [Authenticate]
        public ActionResult AddTarget(int Type, decimal Amount, long EnqId)
        {
            TargetManagement t = new TargetManagement();
            t.Type = Type;
            t.Month = DateTime.Now.Month;
            t.FinancialYear = CurrentFinancialYear();
            t.Amount = Amount;
            t.CenterId = SessionWrapper.User.CentreId;
            t.EnqId = EnqId;
            t.CreatedBy = SessionWrapper.User.UserId;
            t.CreatedDate = DateTime.Now;
            t.ModifyBy = SessionWrapper.User.UserId;
            t.ModifyDate = DateTime.Now;
            var r = _allAarget.AddTarget(t);
            string msg = "";
            if (r == -1)
                msg = "Target already assigned";
            else
                msg = "Target Assigned successfully";
            return Json(msg, JsonRequestBehavior.AllowGet);
        }
    }
}
