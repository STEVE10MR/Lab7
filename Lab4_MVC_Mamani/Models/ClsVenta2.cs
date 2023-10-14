using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab4_MVC_Mamani.Models
{
    public class ClsVenta2
    {
        public bool productoLaptop { get; set; }
        public bool productoDiscoDuro { get; set; }
        public bool productoMonitor { get; set; }
        public bool productoCamaraWeb { get; set; }
        public bool productoImpresora { get; set; }
        public double subtotal { get; set; }
        public double igv { get; set; }
        public double total { get; set; }
    }
}