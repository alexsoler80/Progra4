using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MiprimerMVC.Models
{
    public class Renta
    {
        [Key, Required(ErrorMessage = "Campo Requerido")]
        public int codigoRenta { get; set; }
        [Key, Required(ErrorMessage = "Campo Requerido")]
        public string fecha { get; set; }
        [Key, Required(ErrorMessage = "Campo Requerido")]
        public string fechaEntrega { get; set; }
        [Key, Required(ErrorMessage = "Campo Requerido")]
        public string empleadoRenta { get; set; }
        [Key, Required(ErrorMessage = "Campo Requerido")]
        public string clienteRenta { get; set; }
    }
}