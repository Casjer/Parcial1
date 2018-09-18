using PrimerParcial.BLL;
using PrimerParcial.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace PrimerParcial.DAL
{
    class Contexto : DbContext
    {
        public DbSet<Vendedores> Vendedores { get; set; }
        public Contexto() : base("constr")
        { }
    }
}
