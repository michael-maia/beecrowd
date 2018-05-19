using System;

class Program
{
    static void Main()
    {
        double salary = double.Parse(Console.ReadLine());
        double salary2 = salary;
        double taxesValue = 0;
        int index = 0;
        double tax = 0.08;


        while (salary2 > 0)
        {
            switch (index)
            {
                case 0:
                        salary2 -= 2000.00;
                        index++;
                        break;
                case 1:
                        if (salary2 >= 1000.00)
                        {
                            taxesValue += (1000.00 * tax);
                            salary2 -= 1000.00;
                            index++;                            
                        }
                        else
                        {
                            taxesValue += (salary2 * tax);
                            salary2 -= 1000.00;
                        }
                        break;
                case 2:
                        if (salary2 >= 1500.00)
                        {
                            taxesValue += (1500.00 * (tax + 0.1));
                            salary2 -= 1500.00;
                            index++;
                        }
                        else
                        {
                            taxesValue += (salary2 * (tax + 0.1));
                            salary2 -= 1500.00;
                        }
                        break;
                case 3:
                        taxesValue += (salary2 * (tax + 0.2));
                        salary2 -= 4500.00;
                        break;
                default:
                        break;
            }
        } 
        //test to check which print will show up to the user
        string printTeste = ((taxesValue > 0) ? "R$ " + taxesValue.ToString("0.00") : "Isento");
        Console.WriteLine(printTeste);        
    }
}