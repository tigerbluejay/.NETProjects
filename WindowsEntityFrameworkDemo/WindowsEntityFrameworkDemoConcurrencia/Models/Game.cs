using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WindowsEntityFrameworkDemoConcurrencia.Models
{
    public class Game
    {
        public int GameId { get; set; }
        [ConcurrencyCheck]
        public string Name { get; set; }
    }
}
