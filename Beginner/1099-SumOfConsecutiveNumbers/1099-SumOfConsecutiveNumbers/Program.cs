using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        for (int i = 0; i < N; i++)
        {
            int soma = 0;
            string[] values = Console.ReadLine().Split(' ');
            int k = int.Parse(values[0]);
            int l = int.Parse(values[1]);
            if (k > l) //Esse este é feito para que k seja sempre o menor número, para manter uma ordem crescente
            {
                int aux = l;
                l = k;
                k = aux;
            }
            for (int j = k + 1; j < l; j++) //j começa com k+1 pois o teste é feito em um intervalo aberto de números
            {
                if ((j % 2) == 1)
                {
                    soma += j;
                }
            }
            Console.WriteLine("{0}", soma);
        }
    }
}
