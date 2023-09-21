using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{

    class Program
    {
        static void Main()
        {
            int[] numbers = { 5, 1, 4, 2, 3 };

            // Sorting the array in ascending order
            Array.Sort(numbers);

            // Printing the sorted array
            Console.WriteLine("Sorted Numbers (Ascending):");
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }

            // Sorting the array in descending order
            Array.Reverse(numbers);

            // Printing the sorted array in descending order
            Console.WriteLine("\nSorted Numbers (Descending):");
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }

            Console.Read();

        }
    }











}

