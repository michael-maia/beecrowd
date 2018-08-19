using System;

//Question: https://www.urionlinejudge.com.br/judge/en/problems/view/1078
class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine("{0} x {1} = {2}", i, N, (i * N));
        }
    }
}
