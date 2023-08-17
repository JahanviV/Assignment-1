using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Define an integer array
            int[] numbers = { 2, 4, 6, 8, 10 };

            // Specify the multiplication factor
            int factor = 3;

            // Loop to multiply each element by the factor
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] *= factor;
            }

            // Print the modified array
            Console.WriteLine("Modified array:");
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }
        }
    }
}
