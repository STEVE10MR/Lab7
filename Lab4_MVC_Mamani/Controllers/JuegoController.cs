using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab4_MVC_Mamani.Models;
namespace Lab4_MVC_Mamani.Controllers
{
    public class JuegoController : Controller
    {
        // GET: Juego
        public ActionResult Index(ClsJuego objjuego)
        {
            Random rnd = new Random();
            objjuego.numero1 = rnd.Next(3);
            objjuego.numero2 = rnd.Next(3);
            objjuego.numero3 = rnd.Next(3);

            if((objjuego.numero1 == objjuego.numero2) && (objjuego.numero2 == objjuego.numero3))
            {
                objjuego.resultado = "Ganaste 10,000";
            }
            else if((objjuego.numero1 == objjuego.numero2) || (objjuego.numero2 == objjuego.numero3) || (objjuego.numero1 == objjuego.numero3))
            {
                objjuego.resultado = "Sigue Intentandolo...";
            }
            return View(objjuego);
        }
    }
}