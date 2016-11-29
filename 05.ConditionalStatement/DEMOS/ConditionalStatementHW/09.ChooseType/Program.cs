using System;

namespace _09.ChooseType
{
    class Program
    {
        static void Main()
        {
            string choice = Console.ReadLine();
            
            switch (choice)
            {

                case "integer":
                    Console.WriteLine(int.Parse(Console.ReadLine()) + 1);
                    break;
                case "real":
                    Console.WriteLine("{0:F2}", double.Parse(Console.ReadLine()) + 1);
                    break;
                case "text":
                    Console.WriteLine(Console.ReadLine() + "*");
                    break;
            }
        }
    }
}
