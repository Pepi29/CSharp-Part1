using System;

namespace _01.OddOrEven
{
    class OddOrEven
    {
        static void Main()
        {
            {
                int Number = int.Parse(Console.ReadLine());
                if (Number % 2 == 0)
                    Console.WriteLine("even" + " " + Number);
                else
                    Console.WriteLine("odd" + " " + Number);
            }
        }
    }
}

// учете се да декларирате променливата първо и след това да я парсвате. Правилно написан код, а не директно да задавате, че дад променлива се въвежда в конзолата и се парсва до нещо си!!!
// string s = Console.ReadLine();
// int number = int.Parse(s);
// if(number % 2 == 0)
// {
//      Console.WriteLine("This number is even.")
// }
// else
// {
//      Console.WriteLine("This number is odd.")
// }