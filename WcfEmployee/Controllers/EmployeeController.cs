using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WcfEmployee.WCFServiceEmployee;

namespace WcfEmployee.Controllers
{
    
    public class EmployeeController : Controller
    {
        static WCFServiceEmployee.Service1Client service1Client = new WCFServiceEmployee.Service1Client();
        // GET: Employee
        public ActionResult Index()
        {
            var listEmployee = service1Client.GetList();
            return View(listEmployee);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Save(Employee employee)
        {
            service1Client.Save(employee);
            return RedirectToAction("Index");
        }
    }
}