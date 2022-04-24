using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsDemoHerencia.EntidadesBase
{
    public abstract class Persona
    {
        public Persona(string apellido, string nombre,
            DateTime fechaNacimiento)
        {
            Apellido = apellido;
            Nombre = nombre;
            FechaNacimiento = fechaNacimiento;

        }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
    }
}
