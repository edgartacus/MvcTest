using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcTest.Controllers
{
    public class jQueryUIController : Controller
    {
        //
        // GET: /JqueryUi/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Datepicker()
        {
            return View();
        }

        public ActionResult Autocomplete() {
            return View();
        }

    }
}
