using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{

class Program
    {
        static void Main()
        {
            List<string> fruits = new List<string> { "apple", "banana", "cherry", "date", "grape" };

            // Sorting the list in ascending order
            fruits.Sort();

            // Printing the sorted list
            Console.WriteLine("Sorted Fruits (Ascending):");
            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            // Sorting the list in descending order
            fruits.Reverse();

            // Printing the sorted list in descending order
            Console.WriteLine("\nSorted Fruits (Descending):");
            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }


            Console.Read();


        }
    }













}
