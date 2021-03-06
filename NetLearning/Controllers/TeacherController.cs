﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NetLearning.Models;

namespace NetLearning.Controllers
{
    public class TeacherController : Controller
    {
        private TeacherDBContext db = new TeacherDBContext();

        // GET: Teacher
        public ActionResult Index()
        {
            return View(db.Teacher.ToList());
        }

        // GET: Teacher/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TeacherModel teacherModel = db.Teacher.Find(id);
            if (teacherModel == null)
            {
                return HttpNotFound();
            }
            return View(teacherModel);
        }

        // GET: Teacher/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Teacher/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Section1,grade1,Section2,grade2,Section3,grade3,overall")] TeacherModel teacherModel)
        {
            if (ModelState.IsValid)
            {
                db.Teacher.Add(teacherModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(teacherModel);
        }

        // GET: Teacher/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TeacherModel teacherModel = db.Teacher.Find(id);
            if (teacherModel == null)
            {
                return HttpNotFound();
            }
            return View(teacherModel);
        }

        // POST: Teacher/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Section1,grade1,Section2,grade2,Section3,grade3,overall")] TeacherModel teacherModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(teacherModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(teacherModel);
        }

        // GET: Teacher/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TeacherModel teacherModel = db.Teacher.Find(id);
            if (teacherModel == null)
            {
                return HttpNotFound();
            }
            return View(teacherModel);
        }

        // POST: Teacher/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TeacherModel teacherModel = db.Teacher.Find(id);
            db.Teacher.Remove(teacherModel);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

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
