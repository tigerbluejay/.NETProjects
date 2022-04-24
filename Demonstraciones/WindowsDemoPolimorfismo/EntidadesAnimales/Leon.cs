using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsDemoPolimorfismo.EntidadesAnimales;
namespace WindowsDemoPolimorfismo.EntidadesAnimales
{
    public class Leon : Animal
    {
        bool IsCarnivore;

        public Leon(int edad, int altura, int peso, bool isCarnivore) :
            base (edad,altura,peso)
        {
            IsCarnivore = isCarnivore;
        }

        public override string ImprimirComida()
        {
            return "Come carne";
        }
    }
}
