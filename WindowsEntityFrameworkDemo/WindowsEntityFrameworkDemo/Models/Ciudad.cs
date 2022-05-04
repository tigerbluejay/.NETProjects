using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEntityFrameworkDemo.Models
{
    public class Ciudad
    {
        public int CiudadId { get; set; }
        public string Nombre { get; set; }
        public List<Empleado> Empleados { get; set; }
        public List<Cliente> Clientes { get; set; }
    }
}
