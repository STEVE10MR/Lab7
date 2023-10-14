using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab4_MVC_Mamani.Models;
namespace Lab4_MVC_Mamani.Controllers
{
    public class CajeroController : Controller
    {
        // GET: Cajero
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult DispensarBilletes(ClsCajero objcajero)
        {
            if(objcajero.monto > 0)
            {
                objcajero.b200 = objcajero.monto / 200;
                objcajero.b100 = objcajero.monto % 200 / 100;
                objcajero.b50 = objcajero.monto % 100 / 50;
                objcajero.b20 = objcajero.monto % 50 / 20;
                objcajero.b10 = objcajero.monto % 20 / 10;

                objcajero.cantidad = objcajero.b200+objcajero.b100 + objcajero.b50 + objcajero.b20 + objcajero.b10;
            }
            else
            {
                Response.Write("<script languaje=javascript>alert('ingrese un monto');</script>");
                return View("Index",objcajero); 
            }
            return View(objcajero);
        }
    }
}