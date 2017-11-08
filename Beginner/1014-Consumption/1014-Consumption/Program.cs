using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1014_Consumption
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question: https://www.urionlinejudge.com.br/judge/en/problems/view/1014
            int X;
            double Y, average;
            X = int.Parse(Console.ReadLine());
            Y = double.Parse(Console.ReadLine());
            average = X / Y;
            Console.WriteLine(average.ToString("0.000") + " km/l");
            Console.ReadKey();
        }
    }
}
