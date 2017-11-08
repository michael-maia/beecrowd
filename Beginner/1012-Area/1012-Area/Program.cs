using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1012_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question: https://www.urionlinejudge.com.br/judge/en/problems/view/1012
            double A, B, C, triangle, circle, trapezium, square, rectangle;
            string[] values = Console.ReadLine().Split();
            A = double.Parse(values[0]);
            B = double.Parse(values[1]);
            C = double.Parse(values[2]);
            triangle = A * C / 2;
            circle = 3.14159 * (C * C);
            trapezium = ((A + B) / 2) * C;
            square = B * B;
            rectangle = A * B;
            Console.WriteLine("TRIANGULO: " + triangle.ToString("0.000"));
            Console.WriteLine("CIRCULO: " + circle.ToString("0.000"));
            Console.WriteLine("TRAPEZIO: " + trapezium.ToString("0.000"));
            Console.WriteLine("QUADRADO: " + square.ToString("0.000"));
            Console.WriteLine("RETANGULO: " + rectangle.ToString("0.000"));
            Console.ReadKey();
        }
    }
}
