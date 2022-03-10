using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EFCodeFirstDemo.Models;

namespace EFCodeFirstDemo.Controllers
{
    public class StudentController : Controller
    {

        PGDACContext db = new PGDACContext();//creating DBCotext object for db opertaions
        // GET: Student
        public ActionResult Index()
        {
            //Select * from table
            //return View(db.Students.ToList());
            return View(db.Students.Include("Address").ToList());
        }

        // GET: Student/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Student/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Student/Create
        //Insert Code to save student data
        [HttpPost]
        public ActionResult Create(Student student)
        {

            if (ModelState.IsValid)
            {
                db.Students.Add(student);//adding current entity in context
                db.SaveChanges();//saving in database
                //ViewBag.Message = "Student Data saved Successfully";
                return RedirectToAction("Index");
            }
            return View(student);

        }

        // GET: Student/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Student/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Student/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Student/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
