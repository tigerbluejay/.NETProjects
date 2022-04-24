using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsHerenciaClinica.EntidadesBase;
namespace WindowsHerenciaClinica.Entidades
{
    public class Enfermero : Persona
    {
        public Enfermero(string apellido, string nombre,
            int dni, int legajo):base(apellido,nombre,dni)
        {
            Legajo = legajo;
        }
        public int Legajo { get; set; }
    }
}
