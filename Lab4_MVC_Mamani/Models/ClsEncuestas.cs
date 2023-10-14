using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab4_MVC_Mamani.Models
{
    public class ClsEncuestas
    {
        public string Titulo { get; set; }
        public int cantidadTotal { get; set; }
        public List<ClsAlternativa> Alternativa { get; set; }
    }
}