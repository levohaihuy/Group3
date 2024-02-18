using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFirstApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Product()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult GetEmpName(int EmpID)
        {
            var employess = new[]
            {
                new {EmpID = 1 , EmpName = "Huy" , salary = 7000},
                new {EmpID = 2 , EmpName = "trung" , salary = 7000},
                new {EmpID = 3 , EmpName = "Hieu" , salary = 7000},
            };
            string matchEmpName = null;
            int matchsalary = 0;
            foreach (var item in employess)
            {
               if(item.EmpID == EmpID)
                {
                    matchEmpName = item.EmpName;
                    matchsalary = item.salary;
                }    
            }
            // return new ContentResult() { Content = matchEmpName, ContentType = "text/plain" };
            return Content(matchEmpName + " lương là : " + matchsalary);
           
        }
        public ActionResult GetSalary(int EmpID)
        {
            string FileName = "~/bang-luong" + EmpID + ".pdf";
            return File(FileName, "application/pdf");
        }
        public ActionResult FbPage(int EmpID)
        {
            var employess = new[]
           {
                new {EmpID = 1 , EmpName = "Huy" , salary = 7000},
                new {EmpID = 2 , EmpName = "trung" , salary = 7000},
                new {EmpID = 3 , EmpName = "Hieu" , salary = 7000},
            };
            string youtube = null; 
            foreach (var item in employess)
            {
                if(item.EmpID == EmpID)
                {
                    youtube = "https://www.youtube.com/watch?v=UTJUXlHb17g" + EmpID;
                }
            }
            if(youtube == null)
            {
                return Content("Invalid emp ID");
            }
            else
            {
                return Redirect(youtube);
            }
        }
        public ActionResult empDetail()
        {
            ViewBag.EmpID = 179;
            ViewBag.EmpName = "Huy";
            ViewBag.Salary = 7000;
            return View();
        }
    }
}
    
