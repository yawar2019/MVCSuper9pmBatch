using AdonetExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdonetExample.Controllers
{
    public class EmployeeDetailController : Controller
    {
        // GET: EmployeeDetail

        EmployeeContext db = new EmployeeContext();
        public ActionResult Index()
        {
            return View(db.GetEmployeeList());
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(EmployeeModel emp)
        {
            int i = db.SaveEmployee(emp);
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
            EmployeeModel emp = db.getEmployeeById(id);
            return View(emp);
        }

        [HttpPost]
        public ActionResult Edit(EmployeeModel emp)
        {
            int i = db.UpdateEmployee(emp);
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
            EmployeeModel emp = db.getEmployeeById(id);
            return View(emp);
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int? id)
        {
            int i = db.DeleteEmployee(id);
            if (i > 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        public ActionResult HtmlHelperExample()
        {
            EmployeeModel obj = new EmployeeModel();
            obj.EmpName = "Rahul";
            ViewBag.Empdetail = new SelectList(db.GetEmployeeList(), "EmpId", "EmpName");

            return View(obj);
        }

        public ActionResult ValidationExample()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ValidationExample(RegisterModel reg)
        {
            if (ModelState.IsValid)
            {
                return Redirect("~/EmployeeDetail/ValidationExample");
            }
            else
            {
                return View(reg);

            }
        }
    }
}