using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1020_Age_in_Days
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question: https://www.urionlinejudge.com.br/judge/en/problems/view/1020
            int days = int.Parse(Console.ReadLine());
            int years = days / 365;
            days = days % 365;
            int months = days / 30;
            days = days % 30;
            Console.WriteLine("{0} ano(s)\n{1} mes(es)\n{2} dia(s)", years, months, days);
            Console.ReadKey();
        }
    }
}
