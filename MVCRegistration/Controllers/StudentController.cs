using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCRegistration.Models;


namespace MVCRegistration.Controllers
{
    public class StudentController : Controller
    {
        private DBStudent db = new DBStudent();
        // GET: Student

        public ActionResult Index()
        {
            IList<Student> studentsList = new List<Student>();
            var query = from student in db.Students
                        select student;

            var publishers = query.ToList();
            foreach (var publisherData in publishers)
            {
                studentsList.Add(new Student()
                {
                    Sid = publisherData.Sid,
                    FirstName = publisherData.FirstName,
                    LastName = publisherData.LastName,
                    DOB = publisherData.DOB,
                    Gender = publisherData.Gender,
                    Immunization = publisherData.Immunization,
                    Other = publisherData.Other
                });
            }
            return View(studentsList);

            //var Students = (from eachPub in db.Students select eachPub).ToList();

            //return View(db.Students.ToList());
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
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
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
