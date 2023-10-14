using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab4_MVC_Mamani.Models;
namespace Lab4_MVC_Mamani.Controllers
{
    public class Venta3Controller : Controller
    {
        // GET: Venta3
        public static List<ClsVenta3> listVenta = new List<ClsVenta3>() { new ClsVenta3() { nombre = "Laptop Acer Predator 300", precio = 8999 }, new ClsVenta3() { nombre = "Disco Duro Externo 1TB Sony", precio = 289 }, new ClsVenta3() { nombre = "Monitor HP 23", precio = 750 }, new ClsVenta3() { nombre = "CamaraWeb Logitech Full HD", precio = 120 }, new ClsVenta3() { nombre = "Impresora Multifuncional Epson L3150", precio = 635 } };
        public ActionResult Index()
        {
            return View(listVenta);
        }
        
        public ActionResult CalcularVenta(List<ClsVenta3> venta)
        {
            if (venta != null)
            {
                for (int i = 0; i < venta.Count(); i++)
                {
                    var objVentaActualizada = listVenta.Find(x => x.nombre == venta[i].nombre);
                    if (objVentaActualizada != null)
                    {
                        objVentaActualizada.select = venta[i].select;
                    }
                }
            }
            double SubTotal = 0;
            double Total = 0;
            double IGV = 0;
            foreach (ClsVenta3 objventa in listVenta)
            {
                objventa.subtotal = objventa.precio;
                objventa.total = objventa.subtotal + objventa.subtotal * objventa.Igv;
                if (objventa.select == true)
                {
                    SubTotal += objventa.subtotal;
                    Total += objventa.total;
                    IGV += objventa.subtotal * objventa.Igv;
                }
            }
            ViewBag.Total = Total;
            ViewBag.SubTotal = SubTotal;
            ViewBag.IGV = IGV;
            

            return View(listVenta);
        }
    }
}
