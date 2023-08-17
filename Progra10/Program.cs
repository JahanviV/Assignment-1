using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Define two integer arrays
            int[] array1 = { 2, 4, 6, 8, 10 };
            int[] array2 = { 6, 8, 12, 14, 16 };

            // Call a method to find the common elements
            int[] commonElements = FindCommonElements(array1, array2);

            // Print the common elements
            Console.WriteLine("Common elements between the arrays:");
            foreach (int num in commonElements)
            {
                Console.Write(num + " ");
            }
        }

        static int[] FindCommonElements(int[] arr1, int[] arr2)
        {
            int maxLength = Math.Max(arr1.Length, arr2.Length);
            int[] common = new int[maxLength];
            int commonCount = 0;

            foreach (int num1 in arr1)
            {
                foreach (int num2 in arr2)
                {
                    if (num1 == num2)
                    {
                        common[commonCount] = num1;
                        commonCount++;
                        break; // Exit the inner loop once a common element is found
                    }
                }
            }

            int[] commonElements = new int[commonCount];
            Array.Copy(common, commonElements, commonCount);

            return commonElements;
        }
    }
}
