using System;

class Program
{
    static void Main()
    {
        int n1 = int.Parse(Console.ReadLine());
        int n2 = int.Parse(Console.ReadLine());
        int soma = 0;
        if (n2 < n1)
        {
            int aux = n2;
            n2 = n1;
            n1 = aux;
        }
        for (int i = (n1 + 1); i < n2; i++)
        {
            if (i % 2 != 0)
            {
                soma += i;
            }
        }
        Console.WriteLine(soma);
    }
}
