using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Define an integer array with duplicates
            int[] numbers = { 2, 4, 6, 8, 4, 10, 6, 12, 8 };

            // Call a method to remove duplicates
            int[] uniqueNumbers = RemoveDuplicates(numbers);

            // Print the array with duplicates removed
            Console.WriteLine("Array with duplicates removed:");
            foreach (int num in uniqueNumbers)
            {
                Console.Write(num + " ");
            }
        }

        static int[] RemoveDuplicates(int[] arr)
        {
            int[] tempArray = new int[1000]; // Assuming values are within a certain range
            int uniqueCount = 0;

            foreach (int num in arr)
            {
                if (tempArray[num] == 0)
                {
                    tempArray[num] = 1;
                    uniqueCount++;
                }
            }

            int[] uniqueArray = new int[uniqueCount];
            int index = 0;

            for (int i = 0; i < tempArray.Length; i++)
            {
                if (tempArray[i] == 1)
                {
                    uniqueArray[index] = i;
                    index++;
                }
            }

            return uniqueArray;
        }
    }
}
