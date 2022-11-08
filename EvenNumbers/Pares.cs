using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EvenNumbers
{
    internal class Pares: IPares
    {
        public int Par;

        public Pares()
        {
        }

        public Pares(int par)
        {
            Par=par;
        }

        public int Even(int par = 10) 
        {
            int[] p = new int [10] {0,1,2,3,4,5,6,7,8,9};

            var result = (from m in p
                          where m % 2 == 0
                          select m).ToList();

            foreach (var item in result)
            
            Console.WriteLine(item);
            
            return par;
        }
    }
}
