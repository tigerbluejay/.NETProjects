using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using WindowsEntityFrameworkDemoConcurrencia.Models;

namespace WindowsEntityFrameworkDemoConcurrencia.Data
{
    public class GameDbContext : DbContext
    {
        public GameDbContext() : base("Data Source=localhost;Initial Catalog=DBGame;Integrated Security=True") { }
        public DbSet<Game> Games { get; set; }
    }
}
