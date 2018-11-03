using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1143_SquaredAndCubic
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            for(int i = 1; i <= N; i++)
            {
                Console.WriteLine("{0} {1} {2}", Math.Pow(i, 1), Math.Pow(i, 2), Math.Pow(i, 3));
            }
        }
    }
}
