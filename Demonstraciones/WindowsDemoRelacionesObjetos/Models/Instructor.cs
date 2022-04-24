using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsDemoRelacionesObjetos.Models
{
    public class Instructor : Persona
    {
        public string Titulo { get; set; }

        public List<Materia> Materias { get; set; }
    }
}
