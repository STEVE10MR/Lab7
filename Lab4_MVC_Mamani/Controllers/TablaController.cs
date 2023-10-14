using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab4_MVC_Mamani.Models;

namespace Lab4_MVC_Mamani.Controllers
{
    public class TablaController : Controller
    {
        // GET: Tabla
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult generarTabla(ClsTabla objtabla)
        {
            return View(objtabla);
        }
    }
}