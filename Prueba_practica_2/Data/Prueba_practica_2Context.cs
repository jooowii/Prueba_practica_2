using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Prueba_practica_2.Models;

namespace Prueba_practica_2.Data
{
    public class Prueba_practica_2Context : DbContext
    {
        public Prueba_practica_2Context (DbContextOptions<Prueba_practica_2Context> options)
            : base(options)
        {
        }

        public DbSet<Prueba_practica_2.Models.Empleado> Empleado { get; set; }
    }
}
