using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using COMMON.Models;
using Fixtures.Models;
using Services;

namespace Fixtures.Controllers
{
    //[Authorize]
    public class PropertiesController : Controller
    {
        PropertiesService _propertiesService;

        public PropertiesController()
        {
            _propertiesService = new PropertiesService();
        }
        

        public ActionResult Listing(string location)
        {
            if (location != null)
            {
                return View(_propertiesService.GetPropertiesByLocation(location));
            }
            return View(_propertiesService.GetAllProperties());
        }

        [HttpGet]
        public ActionResult PostAdd()
        {
            return View();
        }

        [HttpPost]
        public ActionResult PostAdd(Property propertyForm)
        {

            //db.Properties.Add(propertyForm);
            //db.SaveChanges();

            return View();
        }


	}
}