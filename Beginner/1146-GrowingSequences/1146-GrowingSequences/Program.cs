using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            int x = int.Parse(Console.ReadLine());
            if (x == 0)
            {
                break;
            }
            for (int i = 1; i <= x; i++)
            {
                if (i < x)
                {
                    Console.Write(i + " ");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}