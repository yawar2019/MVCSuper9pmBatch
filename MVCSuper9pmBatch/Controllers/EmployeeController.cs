using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCSuper9pmBatch.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public int Index()
        {
            return 1;
        }
        public string Index1()
        {
            return "hello world";
        }

        public ActionResult Index2()
        {
          
            return Redirect("~/Employee/Index3");
        }

        public ActionResult Index5()
        {
            return View();
        } 
        public ActionResult Index3()
        {
            return View("JungleView");
        }
        public ActionResult Index4()
        {
            return View("~/Views/Default/Index.cshtml");
        }



        public string Index6(string id )
        {
            return "Hello World for id:"+id+" Name="+Request.QueryString["Name"]+" EmpSalry="+Request.QueryString["EmpSalary"];
        }

        public string Index7(string eid)
        {
            return "Hello World for id:" + eid;
        }
    }
}