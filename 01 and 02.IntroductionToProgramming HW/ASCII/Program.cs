using System;
using System.Text;

namespace ASCII
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            for (int i = 33; i < 127; i++)
            {
                System.Console.Write((char)i);
            }

        }
    }
}
