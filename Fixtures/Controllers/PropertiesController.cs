using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fixtures.Controllers
{
    [Authorize]
    public class PropertiesController : Controller
    {
        //
        // GET: /Properties/
        //public ActionResult Listing()
        //{
        //    return View();
        //}

        public ActionResult Listing(string location)
        {

            return View();
        }
	}
}