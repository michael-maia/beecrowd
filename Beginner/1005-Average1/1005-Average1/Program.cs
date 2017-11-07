using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1005_Average1
{
    class Program
    {
        static void Main(string[] args)
        {
            //If forgot how to do this average, look for "Media Ponderada"
            double A, B, MEDIA;
            A = double.Parse(Console.ReadLine());
            B = double.Parse(Console.ReadLine());
            MEDIA=(A*3.5+B*7.5)/11.0;
            Console.WriteLine("MEDIA = " + MEDIA.ToString("0.00000")); //This is how to print a value with 5 digits after the decimal point
            Console.ReadKey();
        }
    }
}
