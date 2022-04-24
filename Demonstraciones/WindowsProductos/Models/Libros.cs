using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsProductos.Models
{
    public class Libros
    {
        public string Nombre { get; set; }
        public string Editorial { get; set; }
        public int AnoPublicacion { get; set; }
        public bool EsHardcover { get; set; }

        public Libros(string Nombre, string Editorial,
            int AnoPublicacion, bool EsHardcover)
        {
            this.Nombre = Nombre;
            this.Editorial = Editorial;
            this.AnoPublicacion = AnoPublicacion;
            this.EsHardcover = EsHardcover;
        }
    }
}
