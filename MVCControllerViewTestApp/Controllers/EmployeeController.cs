using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCControllerViewTestApp.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index(string type)
        {
            string t = HttpUtility.HtmlEncode(type);
            if (t == "m")
            {
                ViewBag.Title = "Manager Index";
                return View("ManagerIndex");
            } else
            {
                return View();
            }
        }

        public ContentResult Search(string name)
        {
            var input = Server.HtmlEncode(name);
            return Content(input);
        }
    }
}