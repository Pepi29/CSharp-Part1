using System;
using System.Collections.Generic;

namespace _13.MergerSort
{
    class Program
    {
        static void Main()
        {
            
            int length = Convert.ToInt32(Console.ReadLine());
            int[] input = new int[length];
            for (int i = 0; i < length; i++)
            {

                input[i] = Convert.ToInt32(Console.ReadLine());
            }


          
            List<int> temp = new List<int>();
            for (int k = 1; k < length; k *= 2)
            {
                int leftIndex = 0;
                int rightIndex = k;
                int indexCounter = k;
                int counter = 0;
                for (int j = 0; j < length; j++)
                {
                    if (rightIndex == indexCounter + k && leftIndex == indexCounter)  
                    {                                                                
                        leftIndex = rightIndex;                                     
                        rightIndex += k;                                           
                        indexCounter += k + k;                                     
                    }



                    if (rightIndex > (length - 1) - counter && rightIndex != indexCounter + k)
                    {
                        if (rightIndex >= length - 1 && leftIndex == indexCounter)           
                        {                                                               
                            rightIndex = (length - 1) - counter;                          
                            temp.Add(input[rightIndex]);                                
                            break;                                                      
                        }
                        else if (leftIndex < length - 1)
                        {
                            temp.Add(input[leftIndex]);
                            leftIndex++;
                            continue;
                        }
                        else
                        {
                            rightIndex = leftIndex;
                        }
                    }

                    if (rightIndex == indexCounter + k)         
                    {                                          
                        temp.Add(input[leftIndex]);             
                        leftIndex++;                            
                    }
                    else if (rightIndex == leftIndex)
                    {
                        temp.Add(input[rightIndex]);
                        rightIndex++;
                    }
                    else if (leftIndex == indexCounter && rightIndex < indexCounter + k)
                    {
                        temp.Add(input[rightIndex]);
                        rightIndex++;
                    }
                    else if (input[leftIndex] < input[rightIndex])
                    {
                        temp.Add(input[leftIndex]);
                        leftIndex++;
                    }
                    else
                    {
                        temp.Add(input[rightIndex]);
                        rightIndex++;
                    }
                }
                for (int j = 0; j < length; j++)
                {
                    input[j] = temp[j];
                }
                temp = new List<int>();
            }

            
            foreach (int item in input)
            {
                Console.WriteLine(item);
            }
        }
    }
}
