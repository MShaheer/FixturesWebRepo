using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using COMMON.Models;
using Fixtures.Models;

namespace Fixtures.Controllers
{
    [Authorize]
    public class PropertiesController : Controller
    {
        ApplicationDbContext db;

        public PropertiesController()
        {
           db =  new ApplicationDbContext();
        }
        

        public ActionResult Listing(string location)
        {

            return View();
        }

        [HttpGet]
        public ActionResult PostAdd()
        {
            return View();
        }

        [HttpPost]
        public ActionResult PostAdd(Property propertyForm)
        {

            db.Properties.Add(propertyForm);
            db.SaveChanges();

            return View();
        }


	}
}