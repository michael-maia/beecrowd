using System;

class Program
{
    static void Main()
    {
        double salary = double.Parse(Console.ReadLine());
        double salary2 = salary;
        double taxesValue = 0;
        int index = 0;

        if (salary >= 0 && salary <= 2000.00)
        {
            Console.WriteLine("Isento");
        }
        else
        {
            salary2 -= 2000.00;
            //if (salary2 >= 1000.00)
            //{                
            //    taxesValue += (1000.00 * 0.08);
            //    salary2 -= 1000.00;
            //    index++;
            //}
            //else
            //{
            //    taxesValue += (salary2 * 0.08);                
            //}

            //if (salary2 >= 1500.00)
            //{
            //    taxesValue += (1500.00 * 0.18);
            //    salary2 -= 1500.00;
            //    index++;
            //}
            //else
            //{
            //    taxesValue += (salary2 * 0.18);                
            //}

            //if(salary2 >= 4500.00)
            //{
            //    taxesValue += (salary2 * 0.28);                
            //}
            if (salary2 > 2000.00 && salary2 <= 3000.00)
            {
                taxesValue += (1000.00 * 0.08);                               
            }
            else if (salary2 > 3000.00 && salary2 <= 4500.00)
            {
                taxesValue += (1000.00 * 0.08);
                taxesValue += (1500.00 * 0.18);
                
            }           
            else
            {
                taxesValue += (salary2 * 0.28);
            }

            Console.WriteLine("R$ " + taxesValue.ToString("0.00"));
        }
    }
}