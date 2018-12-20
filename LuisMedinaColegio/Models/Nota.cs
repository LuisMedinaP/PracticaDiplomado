using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LuisMedinaColegio.Models
{
    public class Nota
    {
        [Key]
        public int Id { get; set; }
        public int Puntuacion { get; set; }
        public string Materia { get; set; }
        //Relaciones
        virtual public Estudiante Estudiante { get; set; }
        virtual public Profesor Profesor { get; set; }
    }
}