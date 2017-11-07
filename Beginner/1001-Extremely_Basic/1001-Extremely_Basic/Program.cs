using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1001_Extremely_Basic
{
    class Program
    {
        static void Main(string[] args)
        {
            int A,B,X;
            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            X = A + B;
            Console.WriteLine("X = {0}", X);
            Console.ReadKey();
        }
    }
}
