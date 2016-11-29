using System;
using System.Numerics;

namespace _05CalcFact
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            int n = int.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double xPower=x; //тук се съхранява всяко едно повдигнато вече число на дадената степен (2^3; 2^4...) 
            double factorial = 1; 
            double sum = 1 + 1 / x; // това е сумата в началото, преди да се влезе в цикъла. пишем го отвън,
                                    //понеже нямаме степени на първите две събираеми.
            for (int i = 2; i <= n; i++) //
            {
                factorial *= i;
                xPower *= x;
                sum = sum + factorial / xPower;
            }
            Console.WriteLine("{0:F5}", sum);
        }
    }
}
