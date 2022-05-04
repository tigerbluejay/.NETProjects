using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEntityFrameworkDemo.Models
{
    public class Empleado
    {
        public int IdEmpleado { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int CiudadId { get; set; }
        public Ciudad Ciudad { get; set; }
        public List<Factura> Facturas { get; set; }
    }
}
