using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEntityFrameworkDemo.Models
{
    public class Comision
    {
        public decimal ComisionID { get; set; }
        public int Valor { get; set; }
        public DateTime FechadeModificacion { get; set; }
    }
}
