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
            double i, j, k = 1;
            for (i = 0; i <= 2; i += 0.2)
            {
                //A variável k serve para criar a lógica do looping e para alterar o valor inicial do loop em cada ciclo
                for (j = k; j <= (k + 2); j++)
                {
                    Console.WriteLine("I={0} J={1}", i, j);
                }
                k += 0.2;
            }
        }
    }
}
