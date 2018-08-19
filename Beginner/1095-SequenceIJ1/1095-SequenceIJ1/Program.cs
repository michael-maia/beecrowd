using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1095_SequenceIJ1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1, j = 60;
            Console.WriteLine("I={0} J={1}", i, j);
            do
            {
                i += 3;
                j -= 5;
                Console.WriteLine("I={0} J={1}", i, j);
            }
            while (j != 0);
            Console.ReadKey();
        }
    }
}
