using Company.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Company.Controllers
{
    public class CompanyController : Controller
    {
        // GET: Company
        public ActionResult Home()
        {
            ViewBag.Name = "SOFTZENO ";
            return View();
        }
        public ActionResult Services()
        {
            
            var s1 = new Services()
            {
                Name = "Website Development",
                Description= "Our creative and talented team of designers as well as skilled technical developers will build your site to order."
            };

            var s2 = new Services()
            {
                Name = "Mobile App Development",
                Description = "Our engineers continue to build first-class native iOS and Android apps."
            };

            var s3 = new Services()
            {
                Name = "UX-UI Design",
                Description = "Let us translate your concept into a great user experience and highly usable user interface."
            };
            Services[] sr = new Services[] { s1, s2, s3 };
            return View(sr);
        }
        public ActionResult TeamsMember()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
    }
}