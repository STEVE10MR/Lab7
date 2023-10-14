using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab4_MVC_Mamani.Models;

namespace Lab4_MVC_Mamani.Controllers
{
    public class Juego2Controller : Controller
    {
        // GET: Juego2
        public static int[] payTable = { 500000, 100000, 50000, 20000, 10000, 5000, 1000, 500, 200, 100, 50, 20, 10, 0, 0 };
        public ActionResult Index(ClsJuego2 objjuego)
        {
            
            Random rnd = new Random();
            objjuego.codigo01 = rnd.Next(1,16);
            objjuego.codigo02 = rnd.Next(1, 16);
            objjuego.codigo03 = rnd.Next(1, 16);

          

            if (objjuego.codigo01 == objjuego.codigo02 && objjuego.codigo02 == objjuego.codigo03) 
            {
                objjuego.resultado = payTable[objjuego.codigo01];
            }
            else if (objjuego.codigo01 == objjuego.codigo02 || objjuego.codigo01 == objjuego.codigo03 || objjuego.codigo02 == objjuego.codigo03)
            {
                int simboloRepetido = (objjuego.codigo01 == objjuego.codigo02) ? objjuego.codigo01 : objjuego.codigo03;
                objjuego.resultado = payTable[simboloRepetido];
            }
            return View(objjuego);
        }
    }
}