using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Question : https://www.urionlinejudge.com.br/judge/en/problems/view/1047
namespace _1047_GameTimeWithMinutes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] values = Console.ReadLine().Split(' ');
            int h_start = int.Parse(values[0]);
            int m_start = int.Parse(values[1]);
            int h_final = int.Parse(values[2]);
            int m_final = int.Parse(values[3]);
            int h_var = 0,m_var = 0;
            do
            {
                m_start++;
                m_var++;
                if (h_start == 24)
                {
                    h_start = 0;
                }
                else if (m_start == 60)
                {
                    m_start = 0;
                    h_start++;
                }
                else if (m_var == 60)
                {
                    m_var = 0;
                    h_var++;
                }                
                
            } while (!(h_start == h_final && m_start == m_final));
            Console.WriteLine("O JOGO DUROU {0} HORA(S) E {1} MINUTO(S)", h_var, m_var);
            Console.ReadKey();
        }
    }
}
