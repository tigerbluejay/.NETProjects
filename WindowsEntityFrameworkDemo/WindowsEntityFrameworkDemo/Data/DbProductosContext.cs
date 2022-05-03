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
    }
}
