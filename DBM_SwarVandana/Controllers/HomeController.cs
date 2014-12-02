using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using ViewModel;
using Repositories;
using Code;

namespace DBM_SwarVandana.Controllers
{
    public class HomeController : Controller
    {
        // GET: /Home/
        UsersRepository _alluser = new UsersRepository();

        public ActionResult Index()
        {
            UsersViewModel user = new UsersViewModel();
            return View(user);
        }

        [HttpPost]
        public ActionResult Index(UsersViewModel u)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var user = _alluser.Login(u.UserName, u.Password);

                    return RedirectToAction("Index", "Main");
                }
                catch (Exception e)
                {
                    ModelState.AddModelError(string.Empty, e.Message);
                }
            }
            return View();
        }

        public ActionResult LogOut()
        {
            CookieWrapper.UniqueId = 0;
            Session.Abandon();
            return RedirectToAction("Index");
        }

    }
}
