using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsDemoPolimorfismo.EntidadesAnimales
{
    public abstract class Animal
    {
        public int Edad { get; }
        public int Altura { get; }
        public int Peso { get; }

        public Animal(int edad, int altura, int peso)
        {
            Edad = edad;
            Altura = altura;
            Peso = peso;
        }

        public virtual string Imprimir()
        {
            return Edad + ", " + Altura + ", " + Peso;
        }

        public abstract string ImprimirComida();

    }
}
