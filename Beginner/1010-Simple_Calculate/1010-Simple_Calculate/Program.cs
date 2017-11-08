using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1010_Simple_Calculate
{
    class Program
    {
        static void Main(string[] args)
        {
            int code, code2, nUnits, nUnits2;
            double unitPrice, unitPrice2, totalPrice;

            string[] values1 = Console.ReadLine().Split();
            code = int.Parse(values1[0]);
            nUnits = int.Parse(values1[1]);
            unitPrice = double.Parse(values1[2]);

            string[] values2 = Console.ReadLine().Split();
            code2 = int.Parse(values2[0]);
            nUnits2 = int.Parse(values2[1]);
            unitPrice2 = double.Parse(values2[2]);

            totalPrice = unitPrice * nUnits + unitPrice2 * nUnits2;
            Console.WriteLine("VALOR A PAGAR: R$ " + totalPrice.ToString("0.00"));
            Console.ReadKey();
        }
    }
}
