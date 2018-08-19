//Question: https://www.urionlinejudge.com.br/judge/en/problems/view/1094
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1094_Experiments
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int total = 0, t_coelhos = 0, t_ratos = 0, t_sapos = 0;
            for(int i = 0; i < N; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                int quantidade = int.Parse(values[0]);
                string tipo = values[1];
                if(tipo.ToLower() == "c")
                {
                    t_coelhos += quantidade;
                    total += quantidade;
                }
                else if (tipo.ToLower() == "r")
                {
                    t_ratos += quantidade;
                    total += quantidade;
                }
                else
                {
                    t_sapos += quantidade;
                    total += quantidade;
                }
            }
            //Here the cast is necessary othewise the division result will be zero.
            double p_coelhos = ((double)t_coelhos / total) * 100;
            double p_ratos = ((double)t_ratos / total) * 100;
            double p_sapos = ((double)t_sapos / total) * 100;

            Console.WriteLine("Total: {0} cobaias\nTotal de coelhos: {1}\nTotal de ratos: {2}\nTotal de sapos: {3}", total, t_coelhos, t_ratos, t_sapos);
            Console.WriteLine("Percentual de coelhos: {0} %\nPercentual de ratos: {1} %\nPercentual de sapos: {2} %", p_coelhos.ToString("0.00"), p_ratos.ToString("0.00"), p_sapos.ToString("0.00"));
            Console.ReadKey();
        }
    }
}
