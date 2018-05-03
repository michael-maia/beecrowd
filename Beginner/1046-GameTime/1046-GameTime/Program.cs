using System;

class Program
{
    static void Main()
    {
        string[] values = Console.ReadLine().Split(' ');
        int horai = int.Parse(values[0]);
        int horaf = int.Parse(values[1]);
        int contador = 0;

        do
        {
            if (horai == 24)
            {
                horai = 0;
            }
            else
            {
                horai++;
                contador++;
            }
        }
        while (horai != horaf);

        Console.WriteLine("O JOGO DUROU {0} HORA(S)", contador);
    }
}
