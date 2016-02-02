using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MiprimerMVC.Models
{
    public class Pelicula
    {
        [Key, Required(ErrorMessage = "Campo Requerido")]
        public int CodigoPelicula { get; set; }
        [Key, Required(ErrorMessage = "Campo Requerido")]
        public string nombrePelicula { get; set; }
        [Key, Required(ErrorMessage = "Campo Requerido")]
        public string generoPelicula { get; set; }
        [Key, Required(ErrorMessage = "Campo Requerido")]
        public string clasificacionPelicula { get; set; }
        [Key, Required(ErrorMessage = "Campo Requerido")]
        public string duracionPelicula { get; set; }
        [Key, Required(ErrorMessage = "Campo Requerido")]
        public int añoEstrenoPelicula { get; set; }
        [Key, Required(ErrorMessage="Campo Requerido")]
        public string descripcionPelicula { get; set; }


    }
}