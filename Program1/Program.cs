using System;
using System.Collections.Generic; 
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 2, 4, 6, 8, 10 };
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
       
            Console.WriteLine("The sum of the elements is: " + sum);
        }
    }
}
