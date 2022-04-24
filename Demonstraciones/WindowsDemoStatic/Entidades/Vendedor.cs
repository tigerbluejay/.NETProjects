using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsDemoStatic.Entidades
{
    public class Vendedor
    {
        private static int comision = 10;
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public int Legajo { get; set; }
        public static int Comision { 
            get { return comision; }
            set { comision = value; }
        }
        public Vendedor(string apellido, string nombre, int legajo)
        {
            Apellido = apellido;
            Nombre = nombre;
            Legajo = legajo;

        }
    }
}
