﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ejemplo1aspnetmvc.Models
{
    public class ReporteCompra
    {
        public String nombreCliente { get; set; }
        public String documentoCliente { get; set; }
        public DateTime fechaCompra { get; set; }
        public int totalCompra { get; set; }
        
    }
}