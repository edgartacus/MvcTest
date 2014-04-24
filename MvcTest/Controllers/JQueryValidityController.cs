using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcTest.Controllers
{
    public class JQueryValidityController : Controller
    {
        //
        // GET: /jQueryValidity/

        public ActionResult Index()
        {
            string nombre = this.Request.Form["nombre"];
            string apellido = this.Request.Form["apellido"];
            string sexo = this.Request.Form["sexo"];
            return View();
        }

    }
}
