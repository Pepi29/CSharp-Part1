using System;

class MaxEqualElementsSequence
{
    static void Main()
    {

        int length = int.Parse(Console.ReadLine());
        int[] arr = new int[length];
        int maxCount = 0;
        int currentCount = 1;
        int sequenceStart = 0;
        for (int index = 0; index < length; index++)
        {
            arr[index] = int.Parse(Console.ReadLine());
            if (index != 0)
            {
                if (arr[index] == arr[index - 1])
                {
                    currentCount++;
                }
                else
                {
                    currentCount = 1;
                }
                if (currentCount > maxCount)
                {
                    maxCount = currentCount;
                    sequenceStart = index + 1 - maxCount;
                }
            }
        }
        Console.Write(maxCount);
    }
}