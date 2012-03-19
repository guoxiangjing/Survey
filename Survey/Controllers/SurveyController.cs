using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SurveyApp.Models;

namespace SurveyApp.Controllers
{ 
    public class SurveyController : Controller
    {
        private SurveyDBContext db = new SurveyDBContext();

        //
        // GET: /Survey/

        public ViewResult Index()
        {
            return View(db.Surveys.ToList());
        }

        //
        // GET: /Survey/Details/5

        public ViewResult Details(int id)
        {
            Survey survey = db.Surveys.Find(id);
            return View(survey);
        }

        //
        // GET: /Survey/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Survey/Create

        [HttpPost]
        public ActionResult Create(Survey survey)
        {
            if (ModelState.IsValid)
            {
                db.Surveys.Add(survey);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(survey);
        }
        
        //
        // GET: /Survey/Edit/5
 
        public ActionResult Edit(int id)
        {
            Survey survey = db.Surveys.Find(id);
            return View(survey);
        }

        //
        // POST: /Survey/Edit/5

        [HttpPost]
        public ActionResult Edit(Survey survey)
        {
            if (ModelState.IsValid)
            {
                db.Entry(survey).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(survey);
        }

        //
        // GET: /Survey/Delete/5
 
        public ActionResult Delete(int id)
        {
            Survey survey = db.Surveys.Find(id);
            return View(survey);
        }

        //
        // POST: /Survey/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            Survey survey = db.Surveys.Find(id);
            db.Surveys.Remove(survey);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}