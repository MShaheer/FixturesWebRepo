using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fixtures.Controllers
{
    public class UsersController : Controller
    {
        //
        // GET: /Users/
        new public ActionResult Profile()
        {
            return View();
        }
	}
}