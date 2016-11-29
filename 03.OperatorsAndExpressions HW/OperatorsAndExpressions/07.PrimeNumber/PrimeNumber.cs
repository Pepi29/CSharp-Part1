using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.PrimeNumber
{
    class PrimeNumber
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int divider = 2;
            int maxDivider = number;
            while (true && (divider < maxDivider) && (number <=0)) 
            {
                if (number % divider == 0)
                {
                    Console.WriteLine("false");
                }
                divider++;
            }
            Console.WriteLine("true");
        }
    }
}
