using System;

class Program
{
    static void Main()
    {
        int X = int.Parse(Console.ReadLine());
        int Y = int.Parse(Console.ReadLine());
        if (X > Y)
        {
            int aux = Y;
            Y = X;
            X = aux;
        }
        int soma = 0;
        for (int i = X; i <= Y; i++)
        {
            if ((i % 13) != 0)
            {
                soma += i;
            }
        }
        Console.WriteLine(soma);
    }
}
