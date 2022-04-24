using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsHerenciaClinica.EntidadesBase;

namespace WindowsHerenciaClinica.Entidades
{
    public class Paciente : Persona
    {
        public Paciente(string apellido, string nombre,
            int dni, int noHistoriaClinica) : base(
                apellido,nombre,dni)
        {
            NoHistoriaClinica = noHistoriaClinica;
        }
        public int NoHistoriaClinica { get; set; }
    }
}
