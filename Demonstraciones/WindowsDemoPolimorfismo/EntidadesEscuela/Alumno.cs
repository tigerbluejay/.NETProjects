using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsDemoPolimorfismo.EntidadesEscuela
{
    public class Alumno : Persona
    {
        public int Matricula { get; set; }

        public override string Imprimir()
        {
            return base.Imprimir() + "Matricula " + Matricula.ToString();
        }
    }
}
