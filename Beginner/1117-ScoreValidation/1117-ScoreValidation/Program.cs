using System;

class Program
{
    static void Main()
    {
        int contador = 0;
        double soma = 0;
        while (contador != 2)
        {
            double nota = double.Parse(Console.ReadLine());
            if (nota < 0 || nota > 10)
            {
                Console.WriteLine("nota invalida");
            }
            else
            {
                soma += nota;
                contador++;
            }
        }
        double media = soma / 2;
        Console.WriteLine("media = {0}", media.ToString("0.00"));
    }
}
