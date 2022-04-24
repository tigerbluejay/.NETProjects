using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsProductos.Models
{
    public class Herramientas
    {
        public string Nombre { get; set; }
        public int CantidadPiezas { get; set; }
        public bool PoseeComponenteElectronico { get; set; }
        public int Precio { get; set; }

        public Herramientas(string nombre, int cantidadPiezas, 
            bool poseeComponenteElectronico, int precio)
        {
            Nombre = nombre;
            CantidadPiezas = cantidadPiezas;
            PoseeComponenteElectronico = poseeComponenteElectronico;
            Precio = precio;
        }
    }
}
