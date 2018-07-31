using System;

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

            while (number > 0)                      // Infrastructure
            {
                var digit = (int) (number % 10);    // Infrastructure

                if (isOddPos)                       // Domain
                {
                    sum += 3 * digit;               // 3 = parameter
                }
                else
                {
                    sum += digit;                   // += * = infrastructure
                }

                number /= 10;                       // Infrastructure
                isOddPos = !isOddPos;               // Domain
            }

            var modulo = sum % 7;                   // 7 = parameter

            return modulo;                          // % = domain
        }

        private static void Main()
        {
            Console.WriteLine(GetControlDigit(12345));
            Console.ReadLine();
        }
    }
}