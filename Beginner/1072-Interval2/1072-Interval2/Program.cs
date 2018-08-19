using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int contIn = 0, contOut = 0;
        for (int i = 0; i < N; i++)
        {
            int X = int.Parse(Console.ReadLine());
            if (X >= 10 && X <= 20)
            {
                contIn++;
            }
            else
            {
                contOut++;
            }
        }
        Console.WriteLine("{0} in\n{1} out", contIn, contOut);
    }
}
