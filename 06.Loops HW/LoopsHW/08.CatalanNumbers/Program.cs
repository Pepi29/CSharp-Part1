using System;
using System.Numerics;

namespace _08.CatalanNumbers
{
    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
           
            BigInteger factorialN1 = 1;
            BigInteger factorialN = 1;
            BigInteger factorial2N = 1;
            for (int i = 2; i <= 2*N; i++)
            {
                factorial2N *= i;

            }
            for (int i = 2; i <= N; i++)
            {
                factorialN *= i;

            }
            for (int i = 2; i <= N+1; i++)
            {
                factorialN1 *= i;
            }
            Console.WriteLine(factorial2N/(factorialN1*factorialN));
        }
    }
}
