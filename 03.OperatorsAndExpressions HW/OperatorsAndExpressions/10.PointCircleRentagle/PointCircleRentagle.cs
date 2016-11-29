using System;

namespace _10.PointCircleRentagle
{
    class PointCircleRentagle
    {
        static void Main()
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double distance = Math.Sqrt((x * x) + (y * y));
            double r = 2;
            double rectHeight = 2;
            double rectWidth = 6;
            double rectTop = 1;
            double rectLeft = -1;
            if (distance <= r * r)
            {
                Console.Write("inside circle ");
            }
            else
            {
                Console.Write("outside circle ");
            }
            if ((y >= rectTop - rectHeight) && (y <= rectTop) && (x >= rectLeft) && (x <= rectLeft + rectWidth))
            {
                Console.WriteLine("inside rectangle");
            }
            else 
            {
                Console.WriteLine("outside rectagle");
            }
        }
    }
}
