using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsDemoHerencia.EntidadesBase;
namespace WindowsDemoHerencia.Entidades
{
    class Alumno : Persona
    {
        public Alumno(string apellido, string nombre, DateTime fechaNacimiento, int matricula) : base(apellido,nombre,fechaNacimiento)
        {
            Matricula = matricula;
        }
        public int Matricula { get; set; }
    }
}
