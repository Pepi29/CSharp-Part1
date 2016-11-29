using System;

class CompareCharArrays
{
    static void Main()
    {
        Console.WriteLine("Enter firstArray lenght");
        int firstArrayLenght = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter secondArray lenght");
        int secondArrayLenght = int.Parse(Console.ReadLine());

        char[] firstArray = new char[firstArrayLenght];
        char[] secondArray = new char[secondArrayLenght];

        //declare arrays elements
        for (int i = 0; i < Math.Min(firstArrayLenght, secondArrayLenght); i++)
        {
            Console.WriteLine("{0}th element of firstArray:", i);
            firstArray[i] = char.Parse(Console.ReadLine());
            Console.WriteLine("{0}th element of secondArray:", i);
            secondArray[i] = char.Parse(Console.ReadLine());

            if (firstArray[i] > secondArray[i])
            {
                Console.WriteLine("secondArray is first");
                break;
            }
            if (firstArray[i] < secondArray[i])
            {
                Console.WriteLine("firstArray is first");
                break;
            }
            if (firstArrayLenght > secondArrayLenght)
            {
                if (i == secondArrayLenght - 1)
                {
                    Console.WriteLine("secondArray is first");
                }
            }
            else if (firstArrayLenght < secondArrayLenght)
            {
                if (i == firstArrayLenght - 1)
                {
                    Console.WriteLine("firstdArray is first");
                }
            }

        }
    }
}