using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MiprimerMVC.Models
{
    public class Empleado
    {
        [Key, Required(ErrorMessage = "Campo Requerido")]
        public int codigoEmpleado { get; set; }
        [Required(ErrorMessage = "Campo Requerido")]
        public string nombreEmpleado { get; set; }
        [Required(ErrorMessage = "Campo Requerido")]
        public string passwordEmpleado { get; set; }
        [Required(ErrorMessage = "Campo Requerido")]
        public string telefonoEmpleado { get; set; }
        [Required(ErrorMessage = "Campo Requerido")]
        public string direccionEmpleado { get; set; }
    }
}