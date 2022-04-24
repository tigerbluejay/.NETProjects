using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsHerenciaClinica.EntidadesBase;
namespace WindowsHerenciaClinica.Entidades
{
    public class Medico : Persona
    {
        public Medico(string apellido, string nombre,
            int dni, string especialidad, int matricula): base(
                apellido,nombre,dni)
        {
            Especialidad = especialidad;
            Matricula = matricula;
        }
        public string Especialidad { get; set; }
        public int Matricula { get; set; }
    }
}
