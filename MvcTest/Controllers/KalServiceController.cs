using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcTest.Controllers
{
    public class KalServiceController : Controller
    {
        //
        // GET: /KalService/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PaqComplete()
        {
            return View();
        }
    }
}
