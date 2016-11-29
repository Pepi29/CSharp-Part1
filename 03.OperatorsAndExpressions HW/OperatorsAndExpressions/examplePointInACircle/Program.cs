using System;
class BookExperience
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        if ((x - 1) * (x - 1) + (y - 1) * (y - 1) <= 1.5 * 1.5)
        {
            Console.WriteLine("Inside the circle");
        }
        else
        {
            Console.WriteLine("Is outside of the circle");
        }
        if ((x >= -1 && x <= 5) && (y <= 1 && y >= -1))
        {
            Console.WriteLine("and inside the rectangle");
        }
        else
        {
            Console.WriteLine("and outside of the rectangle");
        }
    }
}