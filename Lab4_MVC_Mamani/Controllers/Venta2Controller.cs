using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab4_MVC_Mamani.Models;
namespace Lab4_MVC_Mamani.Controllers
{
    public class Venta2Controller : Controller
    {
        public static double precioLaptop = 8999, precioDisco = 289, precioMonitor = 750, precioCamara = 120,precioImpresora=635;
        // GET: Venta2
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CalcularVenta(ClsVenta2 objventa)
        {
            if (objventa.productoLaptop == true)
            {
                objventa.subtotal = objventa.subtotal + precioLaptop;
            }
            if (objventa.productoDiscoDuro == true)
            {
                objventa.subtotal = objventa.subtotal + precioDisco;
            }
            if (objventa.productoMonitor == true)
            {
                objventa.subtotal = objventa.subtotal + precioMonitor;
            }
            if (objventa.productoCamaraWeb == true)
            {
                objventa.subtotal = objventa.subtotal + precioCamara;
            }
            if (objventa.productoImpresora == true)
            {
                objventa.subtotal = objventa.subtotal + precioImpresora;
            }
            objventa.igv = objventa.subtotal * 0.18;
            objventa.total = objventa.subtotal + objventa.igv;
            return View(objventa);
        }
    }
}