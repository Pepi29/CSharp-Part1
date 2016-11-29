using System;

namespace _06.QadraticEquation
{
    class Program
    {
        static void Main()
        {
            double a, b, c;
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());
            double D, x1, x2;

            D = (b * b) - (4 * a * c);
            //Console.WriteLine(D);
            if (D<0)
            {
                Console.WriteLine("no real roots");
            }
            else if (D==0)
            {
                x1 = ((-b) / (2 * a));
                Console.WriteLine("{0:0.00}", x1);
            }
            else if (D > 0)
            {
                x1 = ((-b) - Math.Sqrt(D)) /(2 * a);
                x2 = ((-b)+ Math.Sqrt(D)) /(2 * a);
                Console.WriteLine("{0:0.00}", Math.Min(x1, x2));
                Console.WriteLine("{0:0.00}", Math.Max(x1, x2));
            }
        }
    }
}
