using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using live_chat2.Models;
using live_chat2.ViewModel;

namespace live_chat2.Controllers
{
    public class FeedbacksController : Controller
    {
        private feedbackEntities db = new feedbackEntities();

        // GET: Feedbacks
        public ActionResult Index()
        {
            

            return View( );
        }

        
        public ActionResult input()
        {
            // writefeedback input = new writefeedback();
            Feedback input = new Feedback();

            return View(input);
        }
       
        public ActionResult output(Feedback f)
        {
            
            if(f.UserID!=null)
            {
                db.Database.ExecuteSqlCommand("insert into Feedback(UserId,Name,Feedback1)" +
                " values('" + f.UserID + "','" + f.Name + "','" + f.Feedback1 + "')");
            }
            

            


            var res = db.Database.SqlQuery<Feedback>("SELECT TOP 5 * FROM Feedback ORDER BY UserID DESC;").ToList();
                             
            return View(res);
        }
         




        // GET: Feedbacks/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Feedback feedback = db.Feedbacks.Find(id);
            if (feedback == null)
            {
                return HttpNotFound();
            }
            return View(feedback);
        }

        // GET: Feedbacks/Create
       

        

        

        

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
