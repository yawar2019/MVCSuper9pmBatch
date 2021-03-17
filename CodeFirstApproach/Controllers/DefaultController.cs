using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CodeFirstApproach.Models;
using System.Data.Entity;

namespace CodeFirstApproach.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        EmployeeContext db = new EmployeeContext();
        public ActionResult Index()
        {

            return View(db.EmployeeModels.ToList());
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(EmployeeModel emp)
        {
            db.EmployeeModels.Add(emp);
            int i = db.SaveChanges();
            if (i > 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View();

            }
        }


        [HttpGet]
        public ActionResult Edit(int? id)
        {
            EmployeeModel emp = db.EmployeeModels.Find(id);
            return View(emp);
        }

        [HttpPost]
        public ActionResult Edit(EmployeeModel emp)
        {
            db.Entry(emp).State = EntityState.Modified;
            int i = db.SaveChanges();
            if (i > 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View();

            }
        }


        [HttpGet]
        public ActionResult Delete(int? id)
        {
            EmployeeModel emp = db.EmployeeModels.Find(id);
            return View(emp);
        }
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int? id)
        {
            EmployeeModel emp = db.EmployeeModels.Find(id);
            db.EmployeeModels.Remove(emp);
            int i = db.SaveChanges();
            if (i > 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View();

            }
        }


        public ActionResult getReadWebService()
        {
            ServiceReference1.WebService1SoapClient obj = new ServiceReference1.WebService1SoapClient();
            obj.Add(100, 200,100);
            return Content(obj.Add(100, 200,100).ToString());
        }
        public ActionResult testwcf()
        {
            ServiceReference2.Service2Client obj = new ServiceReference2.Service2Client();
            
            return Content(obj.HelloGost().ToString());
        }
    }
}