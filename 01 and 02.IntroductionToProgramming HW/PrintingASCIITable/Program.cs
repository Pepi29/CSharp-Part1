using System;
using System.Text;

namespace PrintingASCIITable
{
    class Program
    {
        static void Main()
        {
            for (int i = 33; i <= 126; i++)
            {
                System.Console.Write((char)i);
            }
        }
    }
}
