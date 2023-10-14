using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab4_MVC_Mamani.Models;

namespace Lab4_MVC_Mamani.Controllers
{
    public class Cajero2Controller : Controller
    {
        // GET: Cajero2

        public List<ClsCajero2> lista = new List<ClsCajero2>() {
            new ClsCajero2() { moneda = 0.1,tipo="Centavos" },
            new ClsCajero2() { moneda = 0.2,tipo="Centavos" },
            new ClsCajero2() { moneda = 0.5,tipo="Centavos"},
            new ClsCajero2() { moneda = 1 ,tipo="Monedas"},
            new ClsCajero2() { moneda = 2 ,tipo="Monedas"},
            new ClsCajero2() { moneda = 5 ,tipo="Monedas"},
            new ClsCajero2() { moneda = 10 ,tipo="Billetes"},
            new ClsCajero2() { moneda = 20 ,tipo="Billetes"},
            new ClsCajero2() { moneda = 50 ,tipo="Billetes"},
            new ClsCajero2() { moneda = 100 ,tipo="Billetes"},
            new ClsCajero2() { moneda = 200 ,tipo="Billetes"}, };
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult DispensarBilletes(double monto=0)
        {
            int cantidad = 0;
            ViewBag.Monto = monto;
            if (monto > 0)
            {
                for(int itr = lista.Count()-1; itr >= 0; itr--)
                {
                    lista[itr].cantidad = (int)(Math.Round(monto / lista[itr].moneda, 2, MidpointRounding.AwayFromZero));
                    monto -= lista[itr].cantidad * lista[itr].moneda;

                    if (lista[itr].cantidad > 0)
                    {
                        cantidad += lista[itr].cantidad;
                        lista[itr].view = 1;
                    }
                }
            }
            else
            {
                Response.Write("<script languaje=javascript>alert('ingrese un monto');</script>");
                return View("Index", monto);
            }
            ViewBag.Cantidad = cantidad;
            return View(lista);
        }
        
    }
}