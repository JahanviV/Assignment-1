using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program4
{
    internal class Program
    {
        static void Main(string[] args)
        {        // Define an integer array
            int[] numbers = { 12, 5, 27, 8, 20, 15, 10, 3 };

            // Initialize variables to store counts for even and odd elements
            int evenCount = 0;
            int oddCount = 0;

            // Loop through the array to count even and odd elements
            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                    evenCount++;
                }
                else
                {
                    oddCount++;
                }
            }

            // Print the counts
            Console.WriteLine("Number of even elements: " + evenCount);
            Console.WriteLine("Number of odd elements: " + oddCount);
        }
    }
}
