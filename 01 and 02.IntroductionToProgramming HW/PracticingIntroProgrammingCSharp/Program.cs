using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticingIntroProgrammingCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //int x = 10, y = 5; 
          //  Console.WriteLine("x > y : " + (x > y)); // True 
         //   Console.WriteLine("x < y : " + (x < y)); // False 
          //  Console.WriteLine("x >= y : " + (x >= y)); // True 
          //  Console.WriteLine("x <= y : " + (x <= y)); // False 
          //  Console.WriteLine("x == y : " + (x == y)); // False 
           // Console.WriteLine("x != y : " + (x != y)); // True


         //   int x = 2; 
           // int y = 4; 
           // x *= y; // Same as x = x * y; 
            //Console.WriteLine(x); // 8

            int x = 6; 
            int y = 4; 
            Console.WriteLine(y *= 2); // 8 
            int z = y = 3; // y=3 and z=3 
            Console.WriteLine(z); // 3 
            Console.WriteLine(x |= 1); // 7 
            Console.WriteLine(x += 3); // 10 
            Console.WriteLine(x /= 2); // 5
        }
    }
}
