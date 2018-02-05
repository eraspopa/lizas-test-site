using MvcDataViews.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcDataViews.Controllers
{
    public class FeedbackController : Controller
    {
        static List<Feedback> feedback = new List<Feedback>()
        { new Feedback() {Name="Stranger", Email="someone@example.com", Comment="Awesome!"},
            new Feedback() {Name="Stranger2", Email="example@example.com", Comment="Cute!"}
        };
        // GET: Person
        public ActionResult Index() { return View(feedback); }


        // GET: Person/Details/5
        public ActionResult Details(Feedback p) { return View(p); }

        // GET: Person/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Person/Create
        [HttpPost]
        public ActionResult Create(Feedback p)
        {
            if (!ModelState.IsValid) { return View("Create", p); }

            feedback.Add(p);

            return RedirectToAction("Index");
        }

        // GET: Person/Edit/5
        public ActionResult Edit(int id)
        {
            Feedback p = new Feedback(); foreach (Feedback fb in feedback)
            {
                if (fb.Id == id)
                {
                    p.Name = fb.Name;  p.Id = fb.Id;
                    p.Email = fb.Email; p.Comment = fb.Comment;
                }
            }

            return View(p);
        }

        // POST: Person/Edit/5
        [HttpPost]
        public ActionResult Edit(Feedback p)
        {
            if (!ModelState.IsValid) { return View("Edit", p); }

            foreach (Feedback pn in feedback) { if (pn.Id == p.Id) { pn.Name = p.Name; pn.Id = p.Id; pn.Comment = p.Comment; pn.Email = p.Email; } }

            return RedirectToAction("Index");
        }

        // GET: Person/Delete/5
        public ActionResult Delete(int id)
        {
            Feedback p = new Feedback();
            foreach (Feedback fb in feedback) {
                if (fb.Id == id)
                {
                    p.Name = fb.Name;
                    p.Id = fb.Id;
                    p.Email = fb.Email;
                    p.Comment = fb.Comment;
                }
            }

            return View(p);
        }


        // POST: Person/Delete/5
        [HttpPost]
        public ActionResult Delete(Feedback p)
        {
            try
            {                 // TODO: Add delete logic here            
                foreach (Feedback fb in feedback)
                {
                    if (fb.Id == p.Id)
                    {
                        feedback.Remove(fb);
                    }
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View(p);
            }
        } 

            }
}
