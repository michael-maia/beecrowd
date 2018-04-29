using System;

class Program
{
    static void Main()
    {
        //Question : https://www.urionlinejudge.com.br/judge/en/problems/view/1043

        string[] values = Console.ReadLine().Split(' ');
        float A = float.Parse(values[0]);
        float B = float.Parse(values[1]);
        float C = float.Parse(values[2]);
        float result;
        bool state = false;
        //condition to check if its a triangle or not
        if (A < (B + C) && B < (A + C) && C < (A + B))
        {
            state = true;
        }
        //if state==false, calculate the area of a trapezium
        if (state == false)
        {
            result = (A + B) * C / 2;
            Console.WriteLine("Area = " + result.ToString("0.0"));
        }
        //if state==true, calculate the perimeter of the triangle
        else
        {
            result = A + B + C;
            Console.WriteLine("Perimetro = " + result.ToString("0.0"));
        }
    }
}
