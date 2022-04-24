using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsDemoPolimorfismo.EntidadesAnimales
{
    public class Conejo: Animal
    {
        public bool DomesticAnimal;

        public Conejo(int edad, int altura, int peso, bool domesticanimal) :
            base(edad,altura,peso)
        {
            DomesticAnimal = domesticanimal;
        }
        public override string ImprimirComida()
        {
            return "Come Zanahoria";
        }
    }
}
