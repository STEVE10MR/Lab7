using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab4_MVC_Mamani.Controllers
{
    public class EncuestasController : Controller
    {
        // GET: Encuestas
        public ActionResult Index()
        {
            return View();
        }
    }
}