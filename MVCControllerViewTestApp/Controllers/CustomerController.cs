using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCControllerViewTestApp.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public string Index(string company)
        {
            return HttpUtility.HtmlEncode( "Your company is " + company);
        }

        public string ListAllCustomers()
        {
            return @"<ul>
            <li>Fred Flintstone</li>
            <li>Judy Jetson</li>
            <li>Shaggy Rogers</li>
            <li>Daphne Blake</li>
            </ul>";
        }

    }
}