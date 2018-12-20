using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LuisMedinaColegio.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Contraseña { get; set; }
        //Relaciones
        virtual public Permiso Permiso {get;set;}
    }
}