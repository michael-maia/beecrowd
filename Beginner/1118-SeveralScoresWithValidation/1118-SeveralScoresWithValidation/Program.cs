using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1118_SeveralScoresWithValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            int notaValida = 0;
            bool continuar = true;
            double soma = 0;
            while (continuar == true)
            {   
                if(notaValida == 2)
                {
                    double media = soma / 2;
                    Console.WriteLine("media = {0}", media.ToString("0.00"));
                    int pergunta;
                    do
                    {
                        Console.WriteLine("novo calculo (1-sim 2-nao)");
                        pergunta = int.Parse(Console.ReadLine());
                    } while (pergunta != 1 && pergunta != 2);
                    if (pergunta == 2)
                    {
                        continuar = false;                        
                    }
                    else
                    {
                        notaValida = 0;
                        soma = 0;
                    }
                }
                else
                { 
                    double nota = double.Parse(Console.ReadLine());
                    if (nota >= 0 && nota <= 10)
                    {
                        notaValida++;
                        soma += nota;
                    }
                    else
                    {
                        Console.WriteLine("nota invalida");
                    }
                }
                
            } 
        }
    }
}
