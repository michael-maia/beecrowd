using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1019_Time_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question: https://www.urionlinejudge.com.br/judge/en/problems/view/1019
            int N = int.Parse(Console.ReadLine());
            int hours = N / 3600;
            N = N % 3600;
            int minutes = N / 60;
            N = N % 60;
            Console.WriteLine("{0}:{1}:{2}", hours, minutes, N);
            Console.ReadKey();
        }
    }
}
