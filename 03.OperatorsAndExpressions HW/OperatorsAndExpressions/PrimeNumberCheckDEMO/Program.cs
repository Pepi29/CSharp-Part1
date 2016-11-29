using System;

namespace PrimeNumberCheckDEMO
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
           // if (n % 2 == 0) // ако числото се дели на 2, то не е просто, тъй като четните числа се делят и на 2
           // {
           //     Console.WriteLine("not prime");
           //     return;
           // }
           // else
           // {
           //     Console.WriteLine("prime");
           // }
            int i = 2;
           // int Root = (int)Math.Sqrt(n); // проверката до корен квадратен се прави с цел да се избегне проверка на повтаряща се комбинация
           //                               // например 3*5 и 5*3; ако не намери делител до корен квадратния, значи няма да намери и след това
           // for (int n = 2 ; n <= 100; i++)
           // {
            while (i < Root)
              {
                    if (number % i == 0) //dali chisloto es deli bez ostatyk
                    {
                        Console.WriteLine("{0} is divisible by {1}, {0} is not prime", number, i);
                    }
                    i++;
                  //
                  //{
                  //    Console.WriteLine("alabala");
                  //}
                } //
            }  
            }
            
    }
}
