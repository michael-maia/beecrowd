using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1045_TriangleTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question : https://www.urionlinejudge.com.br/judge/en/problems/view/1045            

            string[] values = Console.ReadLine().Split(' ');            
            double[] sorted = Array.ConvertAll(values, double.Parse);
            //bubble sort
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < (values.Length) - 1; j++)
                {
                    if (sorted[j] > sorted[j + 1])
                    {
                        double aux = sorted[j + 1];
                        sorted[j + 1] = sorted[j];
                        sorted[j] = aux;
                    }
                }
            }  
            //input values sorted, in decreasing order
            double A = sorted[2];
            double B = sorted[1];
            double C = sorted[0];

            bool inputPositive = false;

            if(A > 0 && B > 0 & C > 0)
            {
                inputPositive = true;
            }

            if(inputPositive == true)
            {
                if (A >= B + C)
                {
                    Console.WriteLine("NAO FORMA TRIANGULO");
                }
                else
                {
                    if ((A * A) == (B * B) + (C * C))
                    {
                        Console.WriteLine("TRIANGULO RETANGULO");
                    }
                    else if ((A * A) > (B * B) + (C * C))
                    {
                        Console.WriteLine("TRIANGULO OBTUSANGULO");
                    }
                    else if ((A * A) < (B * B) + (C * C))
                    {
                        Console.WriteLine("TRIANGULO ACUTANGULO");
                    }

                    if (A == B && A == C && B == C)
                    {
                        Console.WriteLine("TRIANGULO EQUILATERO");
                    }
                    else if (A == B || A == C || B == C)
                    {
                        Console.WriteLine("TRIANGULO ISOSCELES");
                    }
                }                
            }
            Console.ReadKey();
        }
    }
}
