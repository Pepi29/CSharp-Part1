using System;

namespace _05.Calculate
{
    class Program
    {
        static void Main()
        {
            double n = double.Parse(Console.ReadLine());
            double k = double.Parse(Console.ReadLine());

            double r = n - k;

            double counter = 1;
            double num = 1;

            for (double i = k + 1; i <= n; i++)
            {
                counter *= i;
                num *= r;
                r--;
            }
            double x = counter / num;
            Console.WriteLine("{0:F5}", x);
        }
    }
}
