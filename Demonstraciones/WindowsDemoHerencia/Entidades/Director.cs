using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsDemoHerencia.Entidades
{
    class Director : Profesor
    {
        public Director(string apellido, string nombre, DateTime fechaNacimiento, string titulo) : base(apellido,nombre,fechaNacimiento,titulo)
        {

        }
    }
}
