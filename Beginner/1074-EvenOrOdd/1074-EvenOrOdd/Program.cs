using System;

class Program
{
    static void Main()
    {
        int numbers = int.Parse(Console.ReadLine()); //How much numbers the code is going to check
        for (int i = 0; i < numbers; i++)
        {
            int N = int.Parse(Console.ReadLine()); //Number to check
            string output1, output2;
            if (N == 0)
            {
                Console.WriteLine("NULL");
            }
            else //If is null we don't need to proceed with the tests below
            {
                if (N % 2 == 0)
                {
                    output1 = "EVEN";
                }
                else
                {
                    output1 = "ODD";
                }

                if (N > 0)
                {
                    output2 = "POSITIVE";
                }
                else
                {
                    output2 = "NEGATIVE";
                }
                Console.WriteLine("{0} {1}", output1, output2);
            }
        }
    }
}

