using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;
using AplicadaProyectoFinal.Entidades;

namespace AplicadaProyectoFinal.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Usuarios> User { get; set; }

        public Contexto() : base("ConStr") { }
    }
}
