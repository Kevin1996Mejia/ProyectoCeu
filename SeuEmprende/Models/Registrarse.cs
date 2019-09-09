using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SeuEmprende.Models
{
    public class Registrarse
    {
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        public int Telefono { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        public int Edad { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Correo { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Estudios { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Dedicacion { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Categoria { get; set; }
    }
}