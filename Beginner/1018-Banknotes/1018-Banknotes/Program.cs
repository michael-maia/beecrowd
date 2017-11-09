using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1018_Banknotes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question: https://www.urionlinejudge.com.br/judge/en/problems/view/1018
            int N = int.Parse(Console.ReadLine());
            int value = N;
            int N100 = N / 100;
            N = N % 100;
            int N50 = N / 50;
            N = N % 50;
            int N20 = N / 20;
            N = N % 20;
            int N10 = N / 10;
            N = N % 10;
            int N5 = N / 5;
            N = N % 5;
            int N2 = N / 2;
            N = N % 2;
            int N1 = N;
            Console.WriteLine(value);
            Console.WriteLine("{0} nota(s) de R$ 100,00",N100);
            Console.WriteLine("{0} nota(s) de R$ 50,00", N50);
            Console.WriteLine("{0} nota(s) de R$ 20,00", N20);
            Console.WriteLine("{0} nota(s) de R$ 10,00", N10);
            Console.WriteLine("{0} nota(s) de R$ 5,00", N5);
            Console.WriteLine("{0} nota(s) de R$ 2,00", N2);
            Console.WriteLine("{0} nota(s) de R$ 1,00", N1);
            Console.ReadKey();
        }
    }
}
