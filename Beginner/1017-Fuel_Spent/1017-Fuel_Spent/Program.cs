using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1017_Fuel_Spent
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question: https://www.urionlinejudge.com.br/judge/en/problems/view/1017
            int time = int.Parse(Console.ReadLine());
            int averageSpeed = int.Parse(Console.ReadLine());
            double averageFuel = 12.0; //Car fuel consumption (12 km/L)
            int distance = averageSpeed * time;
            double liters = distance / averageFuel; //We need at least one double precision variable in the division otherwise we will get a rounded value
            Console.WriteLine(liters.ToString("0.000"));
            Console.ReadKey();
        }
    }
}
