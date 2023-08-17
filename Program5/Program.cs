using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program5
{
    internal class Program
    {
        static void Main(string[] args)
        {// Define an integer array
            int[] numbers = { 2, 4, 6, 8, 10 };

            // Calculate the midpoint of the array
            int midpoint = numbers.Length / 2;

            // Loop to reverse the elements of the array
            for (int i = 0; i < midpoint; i++)
            {
                int temp = numbers[i];
                numbers[i] = numbers[numbers.Length - 1 - i];
                numbers[numbers.Length - 1 - i] = temp;
            }

            // Print the reversed array
            Console.WriteLine("Reversed array:");
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }
        }
    }
}
