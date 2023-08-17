using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Define an integer array
            int[] numbers = { 12, 5, 27, 8, 20, 15 };

            // Initialize a variable to store the largest element
            int largest = numbers[0]; // Assume the first element is the largest

            // Loop through the array to find the largest element
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > largest)
                {
                    largest = numbers[i];
                }
            }

            // Print the largest element
            Console.WriteLine("The largest element in the array is: " + largest);
        }
    }
}
