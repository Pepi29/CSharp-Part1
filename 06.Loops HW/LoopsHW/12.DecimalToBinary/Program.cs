using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.DecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
          //  Console.Write("Decimal: ");
            int decimalNumber = int.Parse(Console.ReadLine());

            int remainder;
            string result = string.Empty;
            if (decimalNumber == 0)
            {
                Console.Write(0);
            }
            while (decimalNumber > 0)
            {
                remainder = decimalNumber % 2;
                decimalNumber /= 2;
                result = remainder.ToString() + result;
            }
            Console.WriteLine(result);
        }
    }
}
