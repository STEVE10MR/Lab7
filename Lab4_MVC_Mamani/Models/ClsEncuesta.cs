using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab4_MVC_Mamani.Models
{
    public class ClsEncuesta
    {
        public string alternativa1 { get; set; }
        public string alternativa2 { get; set; }
        public string alternativa3 { get; set; }
        public int voto1 { get; set; }
        public int voto2 { get; set; }
        public int voto3 { get; set; }
        public double procentaje1 { get; set; }
        public double procentaje2 { get; set; }
        public double procentaje3 { get; set; }
        public int totalVotos { get; set; }
        public double totalPorcentaje { get; set; } 
    }
}