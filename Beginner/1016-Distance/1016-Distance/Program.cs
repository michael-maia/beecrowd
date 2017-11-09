using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1016_Distance
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question: https://www.urionlinejudge.com.br/judge/en/problems/view/1016
            //time and relativeYX should have double precision so we can have the exactly result without data loss
            int distance = int.Parse(Console.ReadLine());
            double relativeYX = 30.0; //Relative velocity of Y in relation of X (relativeYX = velY - velX = 90-60)
            double time = (distance/relativeYX) * 60.0; //Multiply 60 to the result because we want time in minutes not hours
            Console.WriteLine("{0} minutos", time);
            Console.ReadKey();         
        }
    }
}
