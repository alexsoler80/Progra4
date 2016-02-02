using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MiprimerMVC.Models
{
    public class VentaDetalle
    {
        [Key, Required(ErrorMessage = "Campo Requerido")]
        public int codigoFactura { get; set; }
        [Key, Required(ErrorMessage = "Campo Requerido")]
        public int codigoLinea { get; set; }
        [Key, Required(ErrorMessage = "Campo Requerido")]
        public string productoFactura { get; set; }
        [Key, Required(ErrorMessage = "Campo Requerido")]
        public int precioFactura { get; set; }
        [Key, Required(ErrorMessage = "Campo Requerido")]
        public int totalLinea { get; set; }
    }
}