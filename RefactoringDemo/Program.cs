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

            IEnumerable<int> factors = new int[]{3, 1, 3, 1, 3, 1, 3, 1, 3, 1, 3, 1, 3, 1, 3, 1, 3, 1, 3, 1, 3, 1, 3, 1, 3, 1, 3, 1, 3, 1, 3, 1, 3, 1};
            IEnumerator<int> factor = factors.GetEnumerator();

            foreach (var digit in GetDigitsOf(number))
            {
                factor.MoveNext();
                sum += digit * factor.Current;
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