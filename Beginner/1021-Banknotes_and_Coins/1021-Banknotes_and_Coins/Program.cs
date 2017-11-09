using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1021_Banknotes_and_Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question: https://www.urionlinejudge.com.br/judge/en/problems/view/1021
            double N = double.Parse(Console.ReadLine());
            N += 0.0000001; //Using this i got "Accepted" on the question, probably some mathematical logic in C# that i dont know :s
            //We only need to cast our variable N because is the only value that have double precision on the division
            int N100 = (int)N / 100;
            N %= 100;
            int N50 = (int)N / 50;
            N %= 50;
            int N20 = (int)N / 20;
            N %= 20;
            int N10 = (int)N / 10;
            N %= 10;
            int N5 = (int)N / 5;
            N %= 5;
            int N2 = (int)N / 2;
            N %= 2;
            int M100 = (int)N;
            N %= 1;
            //At this point we need to cast this division because both variables have double precision and we need a round value
            int M50 = (int)(N / 0.5);
            N %= 0.5;
            int M25 = (int)(N / 0.25);
            N %= 0.25;
            int M10 = (int)(N / 0.1);
            N %= 0.1;
            int M5 = (int)(N / 0.05);
            N %= 0.05;
            int M1 = (int)(N / 0.01);
            Console.WriteLine("NOTAS:\n{0} nota(s) de R$ 100.00", N100);
            Console.WriteLine("{0} nota(s) de R$ 50.00", N50);
            Console.WriteLine("{0} nota(s) de R$ 20.00", N20);
            Console.WriteLine("{0} nota(s) de R$ 10.00", N10);
            Console.WriteLine("{0} nota(s) de R$ 5.00", N5);
            Console.WriteLine("{0} nota(s) de R$ 2.00", N2);
            Console.WriteLine("MOEDAS:\n{0} moeda(s) de R$ 1.00", M100);
            Console.WriteLine("{0} moeda(s) de R$ 0.50", M50);
            Console.WriteLine("{0} moeda(s) de R$ 0.25", M25);
            Console.WriteLine("{0} moeda(s) de R$ 0.10", M10);
            Console.WriteLine("{0} moeda(s) de R$ 0.05", M5);
            Console.WriteLine("{0} moeda(s) de R$ 0.01", M1);
            Console.ReadKey();
        }
    }
}
