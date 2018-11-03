using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1134_TypeOfFuel
{
    class Program
    {
        static void Main(string[] args)
        {
            int code = 0, alcool = 0, gasolina = 0, diesel = 0;
            while(code != 4){
                code = int.Parse(Console.ReadLine());
                switch (code)
                {
                    case 1:
                        alcool++; break;
                    case 2:
                        gasolina++; break;
                    case 3:
                        diesel++; break;
                    case 4:
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine("MUITO OBRIGADO\nAlcool: {0}\nGasolina: {1}\nDiesel: {2}", alcool, gasolina, diesel);
        }
    }
}
