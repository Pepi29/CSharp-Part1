using System;

namespace _07.PrimeNumbers
{
    class PrimeNumbers
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            if (number == 2 || number == 3)
            {
                Console.WriteLine("true");
                return;
            }
            if (number % 2 == 0)
            {
                Console.WriteLine("false");
                return;
            }
            if (number <= 0 || number <= 1)
            {
                Console.WriteLine("false");
                return;
            }
            int divider = 2;
            int maxDiv = (int)Math.Sqrt(number);
            bool primeNum = true;
            while (primeNum && (divider <= maxDiv) && number <= 100)
            {
                if (number % divider == 0)
                {
                    Console.WriteLine("false");
                }
                else
                {
                    Console.WriteLine("true");
                }
                divider++;
                break;
            }
        }
    }
}
