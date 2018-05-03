using System;

class Program
{
    static void Main()
    {
        double oldSalary = double.Parse(Console.ReadLine());
        double newSalary = 0.0;
        int reajuste = 0;

        if (oldSalary >= 0 && oldSalary <= 400.00)
        {
            newSalary = oldSalary * 1.15;
            reajuste = 15;
        }
        else if (oldSalary <= 800.00)
        {
            newSalary = oldSalary * 1.12;
            reajuste = 12;
        }
        else if (oldSalary <= 1200.00)
        {
            newSalary = oldSalary * 1.10;
            reajuste = 10;
        }
        else if (oldSalary <= 2000.00)
        {
            newSalary = oldSalary * 1.07;
            reajuste = 7;
        }
        else
        {
            newSalary = oldSalary * 1.04;
            reajuste = 4;
        }

        double diferenca = newSalary - oldSalary;

        Console.WriteLine("Novo salario: {0}\nReajuste ganho: {1}\nEm percentual: {2} %", newSalary.ToString("0.00"), diferenca.ToString("0.00"), reajuste);
    }
}