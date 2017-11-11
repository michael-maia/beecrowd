using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1037_Interval
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question: https://www.urionlinejudge.com.br/judge/en/problems/view/1037
            double number = double.Parse(Console.ReadLine());
            if (number < 0 || number > 100)
                Console.WriteLine("Fora de intervalo");
            else if (number >= 0 && number <= 25.00000)
                Console.WriteLine("Intervalo [0,25]");
            else if (number <= 50.00000)
                Console.WriteLine("Intervalo (25,50]");
            else if (number <= 75.00000)
                Console.WriteLine("Intervalo (50,75]");
            else if (number <= 100.00000)
                Console.WriteLine("Intervalo (75,100]");
            Console.ReadKey();
        }
    }
}
