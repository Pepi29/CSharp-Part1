using System;

namespace _15.GreatestCommonDivisor
{
    class Program
    {
        static void Main()
        {

            // Console.WriteLine("Enter two integer a and b:");
            //Read line, and split it by whitespace into an array of strings
            string[] numbers = Console.ReadLine().Split();

            //Parse element 0
            int a = int.Parse(numbers[0]);

            //Parse element 1
            int b = int.Parse(numbers[1]);

            int quotient = 0;
            int remainder = 1;
            while (remainder != 0)
            {
                remainder = a % b;
                quotient = a / b;
                a = b;
                b = remainder;
            }
            Console.WriteLine(a);
        }
    }
}

