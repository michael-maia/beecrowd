using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1036_Bhaskaras_Formula
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question: https://www.urionlinejudge.com.br/judge/en/problems/view/1036
            string[] values = Console.ReadLine().Split();
            double A = double.Parse(values[0]);
            double B = double.Parse(values[1]);
            double C = double.Parse(values[2]);
            //x=-b+-sqrt(b²-4.a.c)/2.a
            double delta = (B * B) - 4 * A * C;
            if (delta < 0 || A <= 0)
                Console.WriteLine("Impossivel calcular");
            else
            {
                delta = Math.Sqrt(delta);
                double x1 = (-B + delta) / (2 * A);
                double x2 = (-B - delta) / (2 * A);
                Console.WriteLine("R1 = "+x1.ToString("0.00000")+"\nR2 = "+x2.ToString("0.00000"));
            }
            Console.ReadKey();
        }
    }
}
