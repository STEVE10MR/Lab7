using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab4_MVC_Mamani.Models;

namespace Lab4_MVC_Mamani.Controllers
{
    public class EncuestaController : Controller
    {
        // GET: Encuesta
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult RealizarEncuesta(ClsEncuesta objencuesta)
        {
            ViewBag.alternativa1 = "Picante";
            ViewBag.alternativa2 = "Ceviche";
            ViewData["alternativa3"] = "Arroz con Pato";

            objencuesta.voto1 = 0;
            objencuesta.voto2 = 0;
            objencuesta.voto3 = 0;
            objencuesta.totalVotos = 0;
            objencuesta.procentaje1 = 0.0d;
            objencuesta.procentaje2 = 0.0d;
            objencuesta.procentaje3 = 0.0d;
            objencuesta.totalPorcentaje = 0.0d;

            if (Request["Plato"] == "Plato 1")
            {
                int contador = 0;
                if (Session["cv1"] == null)
                {
                    Session["cv1"] = 1;
                }
                else
                {
                    contador = Convert.ToInt32(Session["cv1"]);
                    contador++;
                    Session["cv1"] = contador;
                    objencuesta.voto1 = Convert.ToInt32(Session["cv1"]); // Actualizar el valor de voto1 en objencuesta
                    objencuesta.totalVotos += Convert.ToInt32(Session["cv1"]);
                }
            }
            if (Request["Plato"] == "Plato 2")
            {
                int contador = 0;
                if (Session["cv2"] == null)
                {
                    Session["cv2"] = 1;
                }
                else
                {
                    contador = Convert.ToInt32(Session["cv2"]);
                    contador++;
                    Session["cv2"] = contador;
                    objencuesta.voto2 = Convert.ToInt32(Session["cv2"]); // Actualizar el valor de voto2 en objencuesta
                    objencuesta.totalVotos += Convert.ToInt32(Session["cv2"]);
                }
            }
            if (Request["Plato"] == "Plato 3")
            {
                int contador = 0;
                if (Session["cv3"] == null)
                {
                    Session["cv3"] = 1;
                }
                else
                {
                    contador = Convert.ToInt32(Session["cv3"]);
                    contador++;
                    Session["cv3"] = contador;
                    objencuesta.voto3 = Convert.ToInt32(Session["cv3"]); // Actualizar el valor de voto3 en objencuesta
                    objencuesta.totalVotos += Convert.ToInt32(Session["cv3"]);
                }
            }
            Session["totalvotos"] = Convert.ToInt32(Session["cv1"]) + Convert.ToInt32(Session["cv2"]) + Convert.ToInt32(Session["cv3"]);
            Session["vp1"] = Convert.ToDouble(Session["procentajeP1"]).ToString("0.00");
            Session["porcentajeP1"] = ((Convert.ToDouble(Session["cv1"]) * 100.0d) / Convert.ToDouble(Session["totalvotos"])).ToString("0.00");

            Session["vp2"] = Convert.ToDouble(Session["procentajeP2"]).ToString("0.00");
            Session["porcentajeP2"] = ((Convert.ToDouble(Session["cv2"]) * 100.0d) / Convert.ToDouble(Session["totalvotos"])).ToString("0.00");

            Session["vp3"] = Convert.ToDouble(Session["procentajeP3"]).ToString("0.00");
            Session["porcentajeP3"] = ((Convert.ToDouble(Session["cv3"]) * 100.0d) / Convert.ToDouble(Session["totalvotos"])).ToString("0.00");

            Session["totalprocentaje"] = (Convert.ToDouble(Session["procentajeP1"]) + Convert.ToDouble(Session["procentajeP2"]) + Convert.ToDouble(Session["procentajeP3"])).ToString("0");

            return View(objencuesta);
        }
    }
}