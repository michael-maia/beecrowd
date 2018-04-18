using System;
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
            int m_var = 0;
            m_start = (h_start*60) + m_start;
            m_final = (h_final*60) + m_final;
            do
            {
                m_start++;
                m_var++;
            } while (!(m_start == m_final));
            h_var=m_var/60;
            //CONTINUE HERE
            Console.WriteLine("O JOGO DUROU {0} HORA(S) E {1} MINUTO(S)", h_var, m_var);            
        }
    }
}
