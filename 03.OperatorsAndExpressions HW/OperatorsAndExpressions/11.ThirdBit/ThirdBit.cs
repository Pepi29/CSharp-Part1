using System;

namespace _11.ThirdBit
{
    class ThirdBit
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int mask = 3;
            int numRightPossition = number >> mask;
            int bit = numRightPossition & 1;
            Console.WriteLine(bit);       
        }
    }    
}        
         