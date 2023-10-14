using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab4_MVC_Mamani.Models;
namespace Lab4_MVC_Mamani.Controllers
{
    public class VentaController : Controller
    {
        // GET: Venta
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult RealizarVenta(ClsVenta objventa)
        {
            Random valor = new Random();
            objventa.random = valor.Next(1,200);
            return View(objventa);

        }
    }
}