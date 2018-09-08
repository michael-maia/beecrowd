using System;

class Program
{
    static void Main()
    {
        int v_inter = 0, v_gremio = 0, empate = 0, contador = 0;
        while (true)
        {
            string[] resultado = Console.ReadLine().Split(' ');
            int golI = int.Parse(resultado[0]);
            int golG = int.Parse(resultado[1]);
            if (golI > golG)
            {
                v_inter++;
                contador++;
            }
            else if (golI < golG)
            {
                v_gremio++;
                contador++;
            }
            else
            {
                empate++;
                contador++;
            }
            Console.WriteLine("Novo grenal (1-sim 2-nao)");
            int teste = int.Parse(Console.ReadLine());
            if (teste == 2)
            {
                break;
            }
        }
        Console.WriteLine("{0} grenais\nInter:{1}\nGremio:{2}\nEmpates:{3}", contador, v_inter, v_gremio, empate);
        if (v_inter > v_gremio)
        {
            Console.WriteLine("Inter venceu mais");
        }
        else if (v_inter < v_gremio)
        {
            Console.WriteLine("Gremio venceu mais");
        }
        else
        {
            Console.WriteLine("Nao houve vencedor");
        }

    }
}
