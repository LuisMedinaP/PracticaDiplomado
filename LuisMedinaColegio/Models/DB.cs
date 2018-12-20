using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LuisMedinaColegio.Models
{
    public class DB: DbContext
    {
        public DB() : base("DBLuisMedinaEscuela")
        {

        }

        public DbSet<Nota> Notas { get; set; }
        public DbSet<Profesor> Profesores { get; set; }
        public DbSet<Estudiante> Estudiantes { get; set; }
        public DbSet<Permiso> Permisos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}