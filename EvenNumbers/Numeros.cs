using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenNumbers
{
    internal class Numeros: INumeros
    {
        public int Numero;

        public Numeros()
        {
        }

        public Numeros(int numero)
        {
            Numero=numero;
        }

        public int Numbers(int numero=10)
        {
            for(int i=0; i<numero; i++)
            {
                Console.WriteLine(i);
            }
            return numero;
        }
    }
}
