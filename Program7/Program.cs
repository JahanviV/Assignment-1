using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Define an integer array
            int[] numbers = { 12, 5, 27, 8, 20, 15, 10, 3 };

            // Specify the value to search for
            int targetValue = 20;

            // Initialize a variable to store the index of the found value
            int foundIndex = -1; // Default value if not found

            // Loop to search for the target value
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == targetValue)
                {
                    foundIndex = i;
                    break; // Exit the loop once the value is found
                }
            }

            // Print the result
            if (foundIndex != -1)
            {
                Console.WriteLine("Value " + targetValue + " found at index " + foundIndex);
            }
            else
            {
                Console.WriteLine("Value " + targetValue + " not found in the array.");
            }
        }
    }
}
