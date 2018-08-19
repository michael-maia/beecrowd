//Rextester.Program.Main is the entry point for your code. Don't change it.
//Compiler version 4.0.30319.17929 for Microsoft (R) .NET Framework 4.5

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int maior = 0;
            int posicao = 0;
            int[] numeros = new int[100];
            for (int i = 0; i < 100; i++)
            {
                numeros[i] = int.Parse(Console.ReadLine());
                if (numeros[i] > maior)
                {
                    maior = numeros[i];
                    posicao = i;
                }
            }
            Console.WriteLine("{0}\n{1}", maior, posicao + 1);
        }
    }
}