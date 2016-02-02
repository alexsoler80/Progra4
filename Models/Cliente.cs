using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MiprimerMVC.Models
{
    public class Cliente
    {
        [Key, Required(ErrorMessage="Campo Requerido"), Display(Name="Codigo de cliente")]
        public int CodigoCliente { get; set; }
        [Required(ErrorMessage = "Campo Requerido"), Display(Name = "Nombre de Cliente")]
        public string nombreCliente { get; set; }
        [Required(ErrorMessage = "Campo Requerido"), Display(Name = "Dirección de cliente")]
        public string direccionCliente { get; set; }
        [Required(ErrorMessage = "Campo Requerido"), Display(Name = "Genero de cliente")]
        public string generoCliente { get; set; }
        [Required(ErrorMessage = "Campo Requerido"), Display(Name = "Edad de cliente")]
        public int edadCliente { get; set; }
        [Required(ErrorMessage = "Campo Requerido"), Display(Name = "Telefono de cliente")]
        public string telefonoCliente { get; set; }

    }
}