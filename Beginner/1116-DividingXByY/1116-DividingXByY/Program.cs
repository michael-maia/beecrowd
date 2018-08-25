using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        for (int i = 0; i < N; i++)
        {
            string[] valores = Console.ReadLine().Split(' ');
            int x = int.Parse(valores[0]);
            int y = int.Parse(valores[1]);
            if (y == 0)
            {
                Console.WriteLine("divisao impossivel");
            }
            else
            {
                double divisao = (double)x / y;
                Console.WriteLine(divisao.ToString("0.0"));
            }
        }
    }
}
