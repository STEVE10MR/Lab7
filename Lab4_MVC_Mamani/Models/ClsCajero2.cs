using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab4_MVC_Mamani.Models
{
    public class ClsCajero2
    {
        public string tipo { get; set; }
        public double moneda { get; set; }
        public int cantidad { get; set; } = 0;
        public int view { get; set; } = 0;
    }
}