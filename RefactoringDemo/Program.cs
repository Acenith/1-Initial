using System;
using System.Collections.Generic;

namespace RefactoringDemo
{
    internal class Program
    {
        private static int GetControlDigit(long number)
        {
            var sum = 0;
            var isOddPos = true;

            // Seperate digits
            // Loop through digits
            // Multiply every other digit by three
            // Calculate pondered sum of digits
            // Take modulo of 7 of the sum

            // Rule of thumb 
            // More general operations are the infrastructure 
            // Specific operations are genuine parts of the algorithm 
            // Keep these two kinds of operations separate

            foreach (var digit in GetDigitsOf(number))
            {
                if (isOddPos)                       // Domain
                {
                    sum += 3 * digit;               // 3 = parameter
                }
                else
                {
                    sum += digit;                   // += * = infrastructure
                }

                isOddPos = !isOddPos;               // Domain
            }

            var modulo = sum % 7;                   // 7 = parameter

            return modulo;                          // % = domain
        }

        private static IEnumerable<int> GetDigitsOf(long number)
        {
            IList<int> digits = new List<int>();
            while (number > 0)                      // Only infrastructure here in this loop
            {
                digits.Add((int)(number & 10));
                number /= 10;
            }

            return digits;
        }

        private static void Main()
        {
            Console.WriteLine(GetControlDigit(12345));
            Console.ReadLine();
        }
    }
}