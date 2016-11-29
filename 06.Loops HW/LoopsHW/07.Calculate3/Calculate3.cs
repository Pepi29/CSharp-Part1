using System;
using System.Numerics;

namespace _07.Calculate3
{
    class Calculate3
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int K = int.Parse(Console.ReadLine());
            BigInteger factorialK = 1;
            BigInteger factorialN = 1;
            BigInteger factorialNK = 1;
            
            for (int i = 2; i <= N; i++)
            {
                factorialN *= i;
                if (i <= K)
                {
                    factorialK *= i;
                }
            }
            for (int i = 2; i <= (N-K); i++)
            {
                factorialNK *= i;
                
            }
            Console.WriteLine(factorialN / (factorialK * factorialNK));
        }
    }
}
