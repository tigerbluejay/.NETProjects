using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsDemoHerencia.EntidadesBase;

namespace WindowsDemoHerencia.Entidades
{
    class Profesor : Persona
    {
        public Profesor(string apellido, string nombre, DateTime fechaNacimiento, string titulo) : base(apellido, nombre, fechaNacimiento)
        {
            Titulo = titulo;
        }
        public string Titulo { get; set; }
    }
}
