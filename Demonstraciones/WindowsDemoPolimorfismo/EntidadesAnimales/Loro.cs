using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsDemoPolimorfismo.EntidadesAnimales
{
    public class Loro : Animal
    {
        public bool HasFeathers;

        public Loro(int edad, int altura, int peso, bool hasFeathers) :
            base(edad,altura,peso)
        {
            HasFeathers = hasFeathers;
        }

        public override string ImprimirComida()
        {
            return "Come Alpiste";
        }
    }
}
