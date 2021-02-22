using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCSuper9pmBatch.Models;
namespace MVCSuper9pmBatch.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        [Route("Monday/Fantastic4Movie")]
        [Route("Tuesday/SpiderMan")]

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SendData() {

            ViewBag.info = "Hello World";
            return View();
        }

        public ActionResult SendSingleObject()
        {
            Employee Obj = new Employee();
            Obj.EmpId = 1211;
            Obj.EmpName = "Sudha";
            Obj.EmpSalary = 1000;


            // ViewBag.info = Obj;
            return View(Obj);
        }


        public ActionResult SendMultipleObject()
        {

            Employee Obj = new Employee();
            Obj.EmpId = 1211;
            Obj.EmpName = "Sudha";
            Obj.EmpSalary = 1000;

            Employee Obj1 = new Employee();
            Obj1.EmpId = 1212;
            Obj1.EmpName = "Anji";
            Obj1.EmpSalary = 2000;

            Employee Obj2 = new Employee();
            Obj2.EmpId = 1213;
            Obj2.EmpName = "Rajesh";
            Obj2.EmpSalary = 12000;

            List<Employee> listObj = new List<Employee>();
            listObj.Add(Obj);
            listObj.Add(Obj1);
            listObj.Add(Obj2);



            ViewBag.Empinfo = listObj;


            return View();
        }

        public ActionResult SendToDiffObject() {

            Employee Obj = new Employee();
            Obj.EmpId = 1211;
            Obj.EmpName = "Sudha";
            Obj.EmpSalary = 1000;

            DepartmentModel dObj = new Models.DepartmentModel();
            dObj.DeptId = 1;
            dObj.DeptName = "Network";


            EmpDept edObj = new Models.EmpDept();
            edObj.emp = Obj;
            edObj.dept = dObj;


            ViewBag.info = edObj;
            return View();
        }


        public ActionResult SendObjectUsingVModel()
        {
            Employee Obj = new Employee();
            Obj.EmpId = 1211;
            Obj.EmpName = "Sudha";
            Obj.EmpSalary = 1000;



            return View(Obj);
        }

        public ViewResult SendObjmulModel()
        {
            Employee Obj = new Employee();
            Obj.EmpId = 1211;
            Obj.EmpName = "Sudha";
            Obj.EmpSalary = 1000;

            Employee Obj1 = new Employee();
            Obj1.EmpId = 1212;
            Obj1.EmpName = "Anji";
            Obj1.EmpSalary = 2000;

            Employee Obj2 = new Employee();
            Obj2.EmpId = 1213;
            Obj2.EmpName = "Rajesh";
            Obj2.EmpSalary = 12000;

            List<Employee> listObj = new List<Employee>();
            listObj.Add(Obj);
            listObj.Add(Obj1);
            listObj.Add(Obj2);




            return View(listObj);
        }

        public PartialViewResult getpv()
        {
            Employee Obj = new Employee();
            Obj.EmpId = 1211;
            Obj.EmpName = "Sudha";
            Obj.EmpSalary = 1000;
            return PartialView("_myPartialView", Obj);
        }

        public RedirectResult senData() {

            return Redirect("http://www.google.com");
        }

        public RedirectResult senData2(int? id)
        {

            return Redirect("~/Default/SendObjmulModel");
        }

        public RedirectToRouteResult getmeRedirectMethod()
        {
            return RedirectToAction("senData2","Default",new { id = 1 });
        }

        public JsonResult getjsondata()
        {
            Employee Obj = new Employee();
            Obj.EmpId = 1211;
            Obj.EmpName = "Sudha";
            Obj.EmpSalary = 1000;

            Employee Obj1 = new Employee();
            Obj1.EmpId = 1212;
            Obj1.EmpName = "Anji";
            Obj1.EmpSalary = 2000;

            Employee Obj2 = new Employee();
            Obj2.EmpId = 1213;
            Obj2.EmpName = "Rajesh";
            Obj2.EmpSalary = 12000;

            List<Employee> listObj = new List<Employee>();
            listObj.Add(Obj);
            listObj.Add(Obj1);
            listObj.Add(Obj2);




            return Json(listObj,JsonRequestBehavior.AllowGet);
        }

        public FileResult getmeFile() {


            return File("~/Web.config", "application/pdf");

        }
        public ActionResult getmeContent(int ? id) {

            if (id == 1)
            {
                return Content("Hi this is rahul");
            }
            else if (id == 2)
            {
                return Content("<script>alert('Hello from Sudha')</script>");
            }
            else
            {
                return Content("<p style=color:red>Hello i m akash</p>");
            }
        }

    }
}