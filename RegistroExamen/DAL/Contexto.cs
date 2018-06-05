using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RegistroExamen.Entidades;
using System.Data.Entity;

namespace RegistroExamen.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Grupos> Grupos { get; set; }

        public Contexto() : base("ConStr")
        { }
    }
}
