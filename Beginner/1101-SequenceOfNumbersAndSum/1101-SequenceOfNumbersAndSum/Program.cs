using System;

class Program
{
    static void Main()
    {
        while (true) //O teste abaixo vai definir quando o loop para ou não
        {
            string[] numeros = Console.ReadLine().Split(' ');
            int sum = 0;
            int M = int.Parse(numeros[0]);
            int N = int.Parse(numeros[1]);
            if (M <= 0 || N <= 0)
            {
                break; //Caso uma das variaveis seja igual a zero, este break faz com que o loop pare de ser executado na hora
            }
            if (M > N)
            {
                int aux = N;
                N = M;
                M = aux;
            }
            for (int i = M; i <= N; i++)
            {
                sum += i;
                Console.Write("{0} ", i);
            }
            Console.WriteLine("Sum={0}", sum);
        }
    }
}
