using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using WindowsEntityFrameworkDemo.Models;

namespace WindowsEntityFrameworkDemo.Data
{
    class DbProductosContext : DbContext
    {
        // Constructor
        public DbProductosContext() : base("KeyDB")
        {

        }

        // Propiedades para administrar los modelos y sus conexiones

        public DbSet<Producto> Productos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Factura> Facturas { get; set; }
        public DbSet<FacturaDetalle> FacturaDetalles { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Comision> Comisiones { get; set; }
        public DbSet<Ciudad> Ciudades { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // base.OnModelCreating(modelBuilder);
            // establecer clave principal en IdEmpleado
            modelBuilder.Entity<Empleado>().HasKey(e => e.IdEmpleado);

            // establecer not null, campo obligatorio
            modelBuilder.Entity<Empleado>().Property(e => e.Nombre).IsRequired();

            // tipo de datos columna Nombre en la tabla Empleado
            modelBuilder.Entity<Empleado>().Property(e => e.Nombre).HasColumnType("varchar");
            modelBuilder.Entity<Empleado>().Property(e => e.Nombre).HasMaxLength(50);

            // cambiar el nombre de la tabla
            modelBuilder.Entity<Empleado>().ToTable("Empleado");
            modelBuilder.Entity<Empleado>().HasMany(e => e.Facturas);

            modelBuilder.Entity<Comision>().ToTable("Comision");
            modelBuilder.Entity<Comision>().HasKey(c => c.ComisionID);
            modelBuilder.Entity<Comision>().Property(c => c.Valor).IsRequired();

            modelBuilder.Entity<Ciudad>().ToTable("Ciudad");
            modelBuilder.Entity<Ciudad>().HasKey(c => c.CiudadId);
            modelBuilder.Entity<Ciudad>().Property(c => c.Nombre).HasColumnType("varchar").HasMaxLength(20).IsRequired();
            modelBuilder.Entity<Ciudad>().HasMany(c => c.Empleados);
            modelBuilder.Entity<Ciudad>().HasMany(c => c.Clientes);
        }
    }
}
