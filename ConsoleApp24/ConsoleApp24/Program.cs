using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{


    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            string inputString = "programming";

            // Create a dictionary to store the count of each letter
            Dictionary<char, int> letterCounts = new Dictionary<char, int>();

            // Iterate through the characters in the input string
            foreach (char letter in inputString)
            {
                // Check if the letter is already in the dictionary
                if (letterCounts.ContainsKey(letter))
                {
                    // If it is, increment the count
                    letterCounts[letter]++;
                }
                else
                {
                    // If it's not, add it to the dictionary with a count of 1
                    letterCounts[letter] = 1;
                }
            }

            // Print the counts of repeated letters
            foreach (var kvp in letterCounts)
            {
                if (kvp.Value > 1)
                {
                    Console.WriteLine($"Letter '{kvp.Key}' repeats {kvp.Value} times.");
                }
            }

            Console.Read();

        }
    }

}