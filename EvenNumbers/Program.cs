using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenNumbers
{
    class Program
    {        
        static void Main(string[] args)
        {
            var n = new Numeros();
            var p = new Pares();

            Console.WriteLine("Todos os Numeros: ");
            Console.WriteLine(n.Numbers());
            Console.WriteLine("Numeros Pares: ");
            Console.WriteLine(p.Even());

            Console.ReadLine();
        }
    }
}
