using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Rentagles
{
    class Rentagles
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double area = a * b;
            double perimeter = (2 * a) + (2 * b);
            Console.WriteLine("{0:0.00}" , area);
            Console.WriteLine("{0:0.00}" , perimeter);

        }
    }
}
