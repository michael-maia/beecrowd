using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1097_SequenceIJ3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, k = 7;            
            for(i = 1; i <= 9; i += 2)
            {
                //A variável k serve para criar a lógica do looping e para alterar o valor inicial do loop em cada ciclo
                for (j = k; j >= (k - 2); j--)  
                {
                    Console.WriteLine("I={0} J={1}", i, j);
                }
                k += 2;
            }
        }
    }
}
