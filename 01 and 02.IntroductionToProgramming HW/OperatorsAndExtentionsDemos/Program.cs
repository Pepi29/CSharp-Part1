using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAndExtentionsDemos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Demos from lectures
            int a = 5;
            int b = 10;
            Console.WriteLine(a + " " + b);

          //  int store = a;
          //  a = b;
          //  b = store;

            a = a ^ b;
            b = a ^ b;
            a = a ^ b;
            Console.WriteLine(a + " " + b);


        }
    }
}
