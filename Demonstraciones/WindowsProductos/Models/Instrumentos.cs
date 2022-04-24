using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsProductos.Models
{
    public class Instrumentos
    {
        public bool EsPercusion { get; set; }
        public bool EsViento { get; set; }
        public bool EsCuerda { get; set; }
        public string Nombre { get; set; }

        public Instrumentos(bool esPercusion, bool esViento,
            bool esCuerda, string nombre)
        {
            EsPercusion = esPercusion;
            EsViento = esViento;
            EsCuerda = esCuerda;
            Nombre = nombre;
        }
    }
}
