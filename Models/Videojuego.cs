using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MiprimerMVC.Models
{
    public class Videojuego
    {
        [Key, Required(ErrorMessage = "Campo Requerido")]
        public int CodigoJuego { get; set; }
        [Key, Required(ErrorMessage = "Campo Requerido")]
        public string nombreJuego { get; set; }
        [Key, Required(ErrorMessage = "Campo Requerido")]
        public string generoJuego { get; set; }
        [Key, Required(ErrorMessage = "Campo Requerido")]
        public string clasificacionJuego { get; set; }
        [Key, Required(ErrorMessage = "Campo Requerido")]
        public string duracionJuego { get; set; }
        [Key, Required(ErrorMessage = "Campo Requerido")]
        public int añoEstrenoJuego { get; set; }
        [Key, Required(ErrorMessage = "Campo Requerido")]
        public string descripcionJuego { get; set; }

    }
}