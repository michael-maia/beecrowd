using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1044_Multiples
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question : https://www.urionlinejudge.com.br/judge/en/problems/view/1044

            string[] values = Console.ReadLine().Split(' ');
            int A = int.Parse(values[0]);
            int B = int.Parse(values[1]);            

            if (A > B)
            {
                Console.WriteLine(A % B == 0 ? "Sao Multiplos" : "Nao sao Multiplos");
            }
            else
            {
                Console.WriteLine(B % A == 0 ? "Sao Multiplos" : "Nao sao Multiplos");
            }
            Console.ReadKey();

        }
    }
}
