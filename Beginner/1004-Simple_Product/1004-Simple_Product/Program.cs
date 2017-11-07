using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1004_Simple_Product
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, PROD;
            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            PROD = A * B;
            Console.WriteLine("PROD = {0}", PROD);
            Console.ReadKey();
        }
    }
}
