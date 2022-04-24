using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsHerenciaClinica.Entidades
{
    public class Director : Medico
    {
        public Director(string apellido, string nombre,
            int dni, string especialidad, int matricula)
            : base(apellido, nombre, dni,
            especialidad, matricula)
        {

        }
    }
}
