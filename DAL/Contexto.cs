using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea6.Entidades;

namespace Tarea6.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Persona> Personas { get; set; }

        public DbSet<Roles> Roles { get; set; }
        public DbSet<Permisos> Permisos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = DATA\ReguistoCompleto.Db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Permisos>().HasData(
            new Permisos()
            {
                PermisoId = 1,
                DetallePermiso = "Descuento"
            },
            new Permisos()
            {
                PermisoId = 2,
                DetallePermiso = "Venta"
            },
            new Permisos()
            {
                PermisoId = 3,
                DetallePermiso = "Cobrar"
            });
        }
    }
}
