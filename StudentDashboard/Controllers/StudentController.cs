using System.Web.Mvc;
using StudentDashboard.Models;
using System;
using System.Reflection;
using StudentDashboard.ModelBinders;

namespace StudentDashboard.Controllers
{
    public class studentController : Controller
    {
        // GET: Student
        // Retrieve all studentdata
        public ActionResult Index()
        {
            StudentdbHandles getDetails = new Models.StudentdbHandles();
            var model = getDetails.GetAllDetails();
            //@model List< StudentDashboard.Models.StudentModel >
            ViewBag.Students = model;
            return View();
        }

        //[HttpGet]
        //public ActionResult  Create()
        //{
        //    ViewBag.County = "bhagat";
        //    return View();
        //}

        [AcceptVerbs(HttpVerbs.Post | HttpVerbs.Get)]
        public ActionResult Create()
        {
            //read values from request. How?
            //validating against attributes
            //preparing model state dictionary. error text and property
            
            //validation on properties that are not binded?
            
            
            
            StudentdbHandles insertValues = new Models.StudentdbHandles();
            ViewBag.County = "kumar";
            if (ModelState.IsValid == false)
            {
             //   model.LastName = "k";

                StudentModel model = new StudentModel { };
                var isVlaid = TryValidateModel(model);
                return View();
            }
            return RedirectToAction("Index", "Student");
            
        }

        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if (id == null || id <=0)
            {
                return RedirectToRoute("default");
            }
            StudentdbHandles getDetails = new Models.StudentdbHandles();
            var model = getDetails.GetAllDetails().Find(m => m.ID == id);
            if (model != null)
            {
                return View(model);
            }
            return RedirectToRoute("default");
        }


        public void UpdateStudentDetails()
        {
            
        }
        public void DeleteStudentDetails()
        {

        }
    }
}