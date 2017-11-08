using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1013_The_Greatest
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question: https://www.urionlinejudge.com.br/judge/en/problems/view/1013
            int A, B, C, greatest;
            string[] values = Console.ReadLine().Split();
            A = int.Parse(values[0]);
            B = int.Parse(values[1]);
            C = int.Parse(values[2]);
            greatest = (A + B + Math.Abs(A - B)) / 2;
            if (greatest > C)
                Console.WriteLine("{0} eh o maior", greatest);
            else
                Console.WriteLine("{0} eh o maior", C);
            Console.ReadKey();
        }
    }
}
