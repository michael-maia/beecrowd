using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1002_Area_of_a_Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, pi, R;
            pi = 3.14159;
            R = double.Parse(Console.ReadLine());
            A = pi * (R * R);
            Console.WriteLine("A="+A.ToString("0.0000")); //This string format allow only 4 digits to decimal
            Console.ReadKey();
        }
    }
}
