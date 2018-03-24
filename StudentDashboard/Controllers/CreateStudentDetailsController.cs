using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentDashboard.Controllers
{
    public class CreateStudentDetailsController : Controller
    {
        // GET: CreateStudentDetails
        public ActionResult Index()
        {
            return View();
        }

        // GET: CreateStudentDetails/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CreateStudentDetails/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CreateStudentDetails/Create
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

        // GET: CreateStudentDetails/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CreateStudentDetails/Edit/5
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

        // GET: CreateStudentDetails/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CreateStudentDetails/Delete/5
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
