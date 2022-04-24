using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsDemoStatic.Entidades
{
    public class Cliente
    {
        private static int instancias;
        public static int Instancias
        {
            get { return instancias; }
        }
        public string Nombre { get; set; }
        public Cliente(string nombre)
        {
            Nombre = nombre;
            instancias++;
        }
    }
}
