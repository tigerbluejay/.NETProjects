using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsProductos.Models
{
    public class Computadora
    {
        public string Nombre { get; set; }
        public int Precio { get; set; }
        public string Proveedor { get; set; }
        public string Categoria { get; set; }

        public Computadora(string nombre, int precio, string proveedor,
            string categoria)
        {
            Nombre = nombre;
            Precio = precio;
            Proveedor = proveedor;
            Categoria = categoria;

        }
    }
}
