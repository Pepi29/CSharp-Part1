﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOrEven
{
    class OddOrEven
    {
        static void Main()
        {
            int Number = int.Parse(Console.ReadLine());                      
            if (Number % 2 == 0)
                Console.WriteLine("even" + " " + Number);
            else
                Console.WriteLine("odd" + " " + Number);
        }
    }
}
