using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab4_MVC_Mamani.Models
{
    public class ClsVenta3
    {
        public string nombre { get; set; }
        public double precio { get; set; }
        public double subtotal { get; set; }
        public double Igv { get; set; } = 0.18;
        public double total { get; set; }
        public bool select { get; set; }


    }
}