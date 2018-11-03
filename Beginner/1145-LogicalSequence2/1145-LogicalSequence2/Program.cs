using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1145_LogicalSequence2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] values = Console.ReadLine().Split(' ');
            int x = int.Parse(values[0]);
            int y = int.Parse(values[1]);
            for(int i = 1; i <= y; i++)
            {
                for(int j = 0; j < x; j++)
                {
                    if(j != (x-1))
                    {
                        Console.Write("{0} ", i);
                        i++;
                    }
                    else
                    {
                        Console.Write("{0}", i);                        
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
