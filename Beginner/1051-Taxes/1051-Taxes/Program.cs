using System;

class Program
{
    static void Main()
    {
        float salary = float.Parse(Console.ReadLine());
        float salaryTemp = salary;
        float taxValue = 0.00f;

        if (salary <= 2000)
        {
            Console.WriteLine("Isento");
        }
        else
        {
            salaryTemp -= 2000;

            if (salary >= 2000.01)
            {
                if (salaryTemp < 1000)
                {
                    taxValue += salaryTemp * 0.08f;
                }
                else
                {
                    taxValue += 80;
                    salaryTemp -= 1000;
                }
            }
            if (salary >= 3000.01)
            {
                if (salaryTemp < 1000)
                {
                    taxValue += salaryTemp * 0.18f;
                }
                else
                {
                    taxValue += 270;
                    salaryTemp -= 1500;
                }
            }
            if (salary > 4500)
            {
                taxValue += salaryTemp * 0.28f;
            }

            Console.WriteLine($"R$ {taxValue.ToString("0.00")}");
        }
    }
}