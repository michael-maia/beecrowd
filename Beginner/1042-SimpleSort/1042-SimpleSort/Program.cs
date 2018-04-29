using System;

class Program
{
    static void Main()
    {
        //Question : https://www.urionlinejudge.com.br/judge/en/problems/view/1042

        string[] values = Console.ReadLine().Split(' ');
        //take the whole "values" array, convert and send to the integer "unsorted" array
        int[] unsorted = Array.ConvertAll(values, int.Parse);
        int[] sorted = new int[3];
        Array.Copy(unsorted, sorted, unsorted.Length);
        //bubble sort
        for (int i = 0; i < unsorted.Length; i++)
        {
            for (int j = 0; j < (unsorted.Length) - 1; j++)
            {
                if (sorted[j] > sorted[j + 1])
                {
                    int aux = sorted[j + 1];
                    sorted[j + 1] = sorted[j];
                    sorted[j] = aux;
                }
            }
        }
        foreach (int elem in sorted)
        {
            Console.WriteLine(elem);
        }
        Console.WriteLine();
        foreach (int elem in unsorted)
        {
            Console.WriteLine(elem);
        }
    }
}
