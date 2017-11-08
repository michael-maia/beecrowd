using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1008_Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, hoursPerMonth;
            double receivedPerHour,salary;
            number = int.Parse(Console.ReadLine());
            hoursPerMonth = int.Parse(Console.ReadLine());
            receivedPerHour = double.Parse(Console.ReadLine());
            salary = receivedPerHour * hoursPerMonth;
            Console.WriteLine("NUMBER = " + number + "\nSALARY = U$ " + salary.ToString("0.00"));
            Console.ReadKey();
        }
    }
}
