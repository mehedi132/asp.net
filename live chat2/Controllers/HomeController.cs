using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using live_chat2.Models;

namespace live_chat2.Controllers
{
    public class HomeController : Controller
    {
        private feedbackEntities db = new feedbackEntities();
        public ActionResult Chat()
        {
            ViewBag.d = db.Database.SqlQuery<User1>("SELECT Name FROM User1 where Id=3;").ToList();
            return View();
        }
        public ActionResult userinfo()
        {
            return View();
        }
        
    }
}