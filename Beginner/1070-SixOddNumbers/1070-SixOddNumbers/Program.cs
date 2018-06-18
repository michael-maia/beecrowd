using System;

class Program
{
    static void Main()
    {
        int x = int.Parse(Console.ReadLine());
        int contador = 0;
        int i = x;
        do
        {
            if (i % 2 != 0)
            {
                Console.WriteLine(i);
                contador++;
            }
            i++;
        } while (contador != 6);
    }
}
