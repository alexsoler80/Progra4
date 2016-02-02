using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MiprimerMVC.Models
{
    public class Venta
    {
        [Key, Required(ErrorMessage = "Campo Requerido")]
        public int codigoFactura { get; set; }
        [Key, Required(ErrorMessage = "Campo Requerido")]
        public string fechaVenta { get; set; }
        [Key, Required(ErrorMessage = "Campo Requerido")]
        public string empleadoVenta { get; set; }
        [Key, Required(ErrorMessage = "Campo Requerido")]
        public string clienteVenta { get; set; }
    }
}