using System;
using System.Collections.Generic;
using System.Web.Mvc;
using WebApplication1.Business;
using WebApplication1.Filters;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [CustomHandlerError(View = "Error")]
    public class AppraisalController : Controller
    {
        public AppraisalController()
        {
            //BusinessObject = new DomainEntities();
        }

        //[HandleError(View = "Error")]
        //[CustomHandlerError(View ="Error")]
        
        public ViewResult Index()
        {
            //return RedirectToAction("Create");
            //throw new System.Exception();
            List<Appraisal> listAppraisal = null;
            try
            {
                ViewBag.Title = "Appraisals";
                listAppraisal = DomainEntities.Instance.GetAll();
                var error = TempData["Errorid"];
                throw new NullReferenceException("Bhagat raised a exception");

            }
            catch (Exception ex)
            {
                //Log.Error(ex.Message);
                //return View("Error");
                //throw;
            }
            return View(listAppraisal);
        }

        //[CustomHandlerError(View ="CustomError")]
        public ActionResult WebForm1()
        {
            return View();
        }
       
        public ActionResult Details(int id)
        {
            return View();
        }
        
        public ActionResult Create()
        {
            
            return View();
        }

        [HttpPost]
        public ActionResult Create([Bind(Exclude = "Rating")]Appraisal model)
        {
            try
            {
                //business validation rules
                
                if (ModelState.IsValid)
                {
                    var item = DomainEntities.Appraisals.Find(m => m.EmployeeId == model.EmployeeId);
                    if (item != null) return View(model);
                    model.Rating = new System.Random().Next(1, 5);
                    DomainEntities.Appraisals.Add(model);

                    return RedirectToAction("Index");
                }
                else
                {
                    return View(model);
                }
            }
            catch
            {
                return View();
            }
        }

        public JsonResult CreateAsync([Bind(Exclude = "Rating")]Appraisal model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var item = DomainEntities.Appraisals.Find(m => m.EmployeeId == model.EmployeeId);
                    if (item != null) return new JsonResult { Data = false };
                    model.Rating = new System.Random().Next(1, 5);
                    DomainEntities.Appraisals.Add(model);
                    return new JsonResult { Data = true };
                }
                else
                {
                    return new JsonResult { Data = false };
                }
            }
            catch
            {
                return new JsonResult { Data = false };
            }
        }

        public ActionResult CreateAsync1([Bind(Exclude = "Rating")]Appraisal model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var item = DomainEntities.Appraisals.Find(m => m.EmployeeId == model.EmployeeId);
                    if (item != null) return new EmptyResult();
                    model.Rating = new System.Random().Next(1, 5);
                    DomainEntities.Appraisals.Add(model);
                    return PartialView(model);
                }
                else
                {
                    return new EmptyResult();
                }
            }
            catch
            {
                return new EmptyResult();
            }
        }
        
        public ActionResult Edit(int id)
        {
            var model = DomainEntities.Instance.GetAppraisal(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(Appraisal model)
        {
            try
            {
                // TODO: Add update logic here
                if (ModelState.IsValid)
                {
                    var item = DomainEntities.Appraisals.Find(m => m.EmployeeId == model.EmployeeId);
                    if (item == null) return View(model);
                    item.Appraisee = model.Appraisee;
                    item.Appraiser = model.Appraiser;
                    item.Rating = model.Rating;
                    item.Applicable = model.Applicable;
                    return RedirectToAction("Index");
                }
                else
                {
                    return View(model);
                }
            }
            catch
            {
                return View();
            }
        }
        [HttpGet]
        public ActionResult View(int id)
        {
            
                var modelvalue = DomainEntities.Instance.GetAppraisal(id);

            if (DomainEntities.Appraisals.Exists(m=>m.EmployeeId==id))
            {
                //ViewData["Errorid"] = "id";
                TempData["Errorid"] = "invalid ID";
                return RedirectToAction("Index"); 
            }

            else if (modelvalue == null)
            {
                ViewBag.AlertMsg = "Invalid Emplyoee id";
                // return RedirectToAction("Index");
                //show index screen
                //show error if any 

            }
            
            return View(modelvalue);
        }
                
            
             
            
        
        
        [HttpPost]
        public ActionResult Delete(int id)
        {
            try
            {
                //if(ModelState.IsValid)
                // {

                var item = DomainEntities.Appraisals.Find(m => m.EmployeeId == id);
                DomainEntities.Appraisals.Remove(item);



                // }


            }
            catch (Exception e)
            {
                
                ViewBag.AlertMsg= e.Message;
            }
            return RedirectToAction("Index");
        }

        public ActionResult Adresstemplete()
        {
            return PartialView();
        }
    }
}
