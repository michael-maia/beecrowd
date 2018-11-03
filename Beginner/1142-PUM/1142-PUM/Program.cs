using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1142_PUM
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int j = 0;
            for(int i = 0; i < N; i++)
            {
                Console.WriteLine("{0} {1} {2} PUM", j + 1, j + 2, j + 3);
                j += 4;
            }
        }
    }
}
