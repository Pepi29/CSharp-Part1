

// 04. Write an expression that checks for given integer if its third digit (right-to-left) is 7. E. g. 1732 ? true.
 
using System;
 
class ThirdDigit
{
    static void Main()
    {
        Console.Write("Please enter a number: ");
        int number = int.Parse(Console.ReadLine());
         
        if (((number / 100) % 10)== 7)
        {
            Console.WriteLine("The third digits IS seven!");
        }
        //ако числото е 701, делим на 100 и махаме последните 2 цифри, тъй като е целочислено деление, след това делим на 10 и проверяваме дали остатъка е 7, ако да- вярно, ако не грешно!
        else
        {
            Console.WriteLine("The third digit IS NOT seven.");
        }
    }
}