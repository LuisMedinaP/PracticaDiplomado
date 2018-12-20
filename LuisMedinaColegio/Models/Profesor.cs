using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LuisMedinaColegio.Models
{
    public class Profesor
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        //Relaciones
        virtual public List<Nota> Notas { get; set; }
        
    }
}