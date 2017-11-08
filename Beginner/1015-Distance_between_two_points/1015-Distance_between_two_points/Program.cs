using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1015_Distance_between_two_points
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question: https://www.urionlinejudge.com.br/judge/en/problems/view/1015
            double x1, x2, y1, y2, distance;
            string[] valuesX = Console.ReadLine().Split();
            x1 = double.Parse(valuesX[0]);
            y1 = double.Parse(valuesX[1]);
            string[] valuesY = Console.ReadLine().Split();
            x2 = double.Parse(valuesY[0]);
            y2 = double.Parse(valuesY[1]);
            distance = Math.Sqrt(Math.Pow(x2 - x1, 2.0) + Math.Pow(y2 - y1, 2.0));            
            Console.WriteLine(distance.ToString("0.0000"));
            Console.ReadKey();
        }
    }
}
