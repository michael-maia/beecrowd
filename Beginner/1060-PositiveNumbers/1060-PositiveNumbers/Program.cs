using System;

class Program
{
    static void Main()
    {
        int contador = 0;
        for (int i = 0; i < 6; i++)
        {
            double number = double.Parse(Console.ReadLine());
            if (number > 0)
            {
                contador++;
            }
        }
        Console.WriteLine("{0} valores positivos", contador);
    }
}
