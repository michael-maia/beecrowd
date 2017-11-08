using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1009_Salary_with_Bonus
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            double fixedSalary, saleTotal, finalSalary;
            name = Console.ReadLine();
            fixedSalary = double.Parse(Console.ReadLine());
            saleTotal = double.Parse(Console.ReadLine());
            finalSalary = fixedSalary + saleTotal * 0.15;
            Console.WriteLine("TOTAL = R$ " + finalSalary.ToString("0.00"));
            Console.ReadKey();
        }
    }
}
