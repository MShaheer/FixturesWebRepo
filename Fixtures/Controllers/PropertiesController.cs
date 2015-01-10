using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using COMMON.Models;
using Fixtures.Models;

namespace Fixtures.Controllers
{
    //[Authorize]
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
        public ActionResult PostAd()
        {
            ViewBag.Type = PropertyTypeComboData();
            return View();
        }

        [HttpPost]
        public ActionResult PostAd(Property propertyForm)
        {

            db.Properties.Add(propertyForm);
            db.SaveChanges();

            return View();
        }

        public List<SelectListItem> PropertyTypeComboData()
        {

            List<SelectListItem> items = new List<SelectListItem>();

            items.Add(new SelectListItem { Text = "Apartment", Value = "0" });

            items.Add(new SelectListItem { Text = "House", Value = "1" });

            items.Add(new SelectListItem { Text = "Bed & Breakfast", Value = "2", Selected = true });

            items.Add(new SelectListItem { Text = "Villa", Value = "3" });

            items.Add(new SelectListItem { Text = "Other", Value = "4" });

           

            return items;

        }


	}
}