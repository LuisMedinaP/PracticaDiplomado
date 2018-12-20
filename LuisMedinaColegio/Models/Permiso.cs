using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LuisMedinaColegio.Models
{
    public class Permiso
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
    }
}