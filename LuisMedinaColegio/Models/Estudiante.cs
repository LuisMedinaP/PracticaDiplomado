using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LuisMedinaColegio.Models
{
    public class Estudiante
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public bool Sexo { get; set; }
        public string Direccion { get; set; }
        public string Contacto1 { get; set; }
        public string Contacto2 { get; set; }
        //public HttpPostedFileBase ImagenFile { get; set; }
        public string Imagen { get; set; }
        //Relaciones
        virtual public List<Nota> Notas { get; set; }
    }
}