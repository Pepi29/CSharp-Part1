using System;

namespace _03.DividedBy7and5
{
    class divideBy7and5
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            if ((number % 7 == 0 )&&(number % 5 == 0)) //(number % 7==0 || number % 5==0) - ili ednoto ili drugoto
            {
                Console.WriteLine("true " + number);
            }
            else
            {
                Console.WriteLine("false " + number);
            }
        }
    }
}
