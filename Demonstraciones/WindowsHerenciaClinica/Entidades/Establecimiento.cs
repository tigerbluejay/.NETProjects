using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsHerenciaClinica.Entidades
{
    public class Establecimiento
    {
        public Establecimiento(string nombre, string domicilio)
        {
            Nombre = nombre;
            Domicilio = domicilio;
        }
        public string Nombre { get; set; }
        public string Domicilio { get; set; }
    }
}
