using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using live_chat2.Models;

namespace live_chat2.Controllers
{
    public class userinfoController : Controller
    {
        
        private feedbackEntities db = new feedbackEntities();
        public ActionResult updatepassword()
        {
            ViewBag.d = db.Database.SqlQuery<User1>("SELECT *FROM User1 where Id=1;").ToList();

            return View();
        }

        public ActionResult recentPurchase()
        {

            ViewBag.d = db.Database.SqlQuery<User1>("SELECT *FROM User1 where Id=1;").ToList();

            return View();
        }

        public ActionResult UserProfileUpdate(User1 u)
        {
           

            if (u.Name!=null)
            {
                db.Database.ExecuteSqlCommand("update User1 set Name='" + u.Name + "' , Address='" + u.Address + "', Email='" + u.Email + "' where Id=1");

            }
            ViewBag.d = db.Database.SqlQuery<User1>("SELECT *FROM User1 where Id=1;").ToList();
            return View();


            
        }

        public ActionResult ticketcancellation()
        {

            ViewBag.d = db.Database.SqlQuery<User1>("SELECT *FROM User1 where Id=1;").ToList();

            return View();
        }







    }
}