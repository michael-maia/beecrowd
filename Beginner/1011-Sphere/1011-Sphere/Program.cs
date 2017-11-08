using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1011_Sphere
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question: https://www.urionlinejudge.com.br/judge/en/problems/view/1011
            double R, volume;
            R = double.Parse(Console.ReadLine());
            volume = (4.0 / 3.0) * 3.14159 * (R * R * R);
            Console.WriteLine("VOLUME = " + volume.ToString("0.000"));
            Console.ReadKey();
        }
    }
}
