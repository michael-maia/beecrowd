using System;

class Program
{
    static void Main()
    {
        string word1 = Console.ReadLine();
        string word2 = Console.ReadLine();
        string word3 = Console.ReadLine();

        if (word1.ToLower() == "vertebrado")
        {
            if (word2.ToLower() == "ave")
            {
                if (word3.ToLower() == "carnivoro")
                {
                    Console.WriteLine("aguia");
                }
                else //onivoro
                {
                    Console.WriteLine("pomba");
                }
            }
            else //mamifero
            {
                if (word3.ToLower() == "onivoro")
                {
                    Console.WriteLine("homem");
                }
                else //herbivoro
                {
                    Console.WriteLine("vaca");
                }
            }
        }
        else //invertebrado
        {
            if (word2.ToLower() == "inseto")
            {
                if (word3.ToLower() == "hematofago")
                {
                    Console.WriteLine("pulga");
                }
                else //herbivoro
                {
                    Console.WriteLine("lagarta");
                }
            }
            else //anelideo
            {
                if (word3.ToLower() == "hematofago")
                {
                    Console.WriteLine("sanguessuga");
                }
                else //onivoro
                {
                    Console.WriteLine("minhoca");
                }
            }
        }
    }
}
