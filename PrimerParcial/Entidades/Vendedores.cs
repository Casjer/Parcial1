using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace PrimerParcial.Entidades
{
    public class Vendedores
    {
        [Key]
        public int VendedroresId { get; set; }
        public string Nombre { get; set; }
        public decimal Sueldo { get; set; }
        public decimal Retencion { get; set; }

        public Vendedores(int vendedroresId, string nombre, decimal sueldo, decimal retencion)
        {
            VendedroresId = vendedroresId;
            Nombre = nombre;
            Sueldo = sueldo;
            Retencion = retencion;
        }

       
    }

  
}
