using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        for (int i = 1; i <= N; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine("{0}^2 = {1}", i, (i * i));
            }
        }
    }
}
