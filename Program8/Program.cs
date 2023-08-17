using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program8 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Define an integer array
            int[] numbers = { 12, 5, 27, 8, 20, 15, 10, 3 };

            // Call a method to find the second smallest element
            int secondSmallest = FindSecondSmallest(numbers);

            // Print the result
            Console.WriteLine("The second smallest element in the array is: " + secondSmallest);
        }

        static int FindSecondSmallest(int[] arr)
        {
            if (arr.Length < 2)
            {
                throw new ArgumentException("Array must have at least two elements.");
            }

            // Perform selection sort to sort the array
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }
                int temp = arr[minIndex];
                arr[minIndex] = arr[i];
                arr[i] = temp;
            }

            // The second smallest element will be at index 1 after sorting
            return arr[1];
        }
    }
}
