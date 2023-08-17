using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float[] values = { 2.5f, 4.7f, 6.2f, 8.9f, 10.1f };

            // Initialize variables to store the sum and count
            float sum = 0;
            int count = values.Length;

            // Loop through the array and calculate the sum of elements
            for (int i = 0; i < count; i++)
            {
                sum += values[i];
            }

            // Calculate the average
            float average = sum / count;

            // Print the average
            Console.WriteLine("The average of the values is: " + average);
        }
    }
}
