﻿using System;
namespace _10.BinaryToDec
{
    class Program
    {
        static void Main()
        {
            
            string binary = Console.ReadLine();
            long dec = 0;
            for (int i = 0; i < binary.Length; i++)
            {
                if (binary[binary.Length - i - 1] == '0')
                {
                    continue;
                }
                dec += (long)Math.Pow(2, i);
            }
            Console.WriteLine(dec);
        }
    }
}

