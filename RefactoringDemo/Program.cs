using System;
using System.Collections.Generic;
using System.Linq;

namespace RefactoringDemo
{
    internal class Program
    {
        // Seperate digits
        // Loop through digits
        // Multiply every other digit by three
        // Calculate pondered sum of digits
        // Take modulo of 7 of the sum

        // Rule of thumb 
        // More general operations are the infrastructure 
        // Specific operations are genuine parts of the algorithm 
        // Keep these two kinds of operations separate

        private static int GetControlDigit(long number) =>
            number
                .DigitsFromLowest()
                .Zip(MultiplyingFactors, (a, b) => a * b)
                .Sum()
                % 7;

        private static IEnumerable<int> MultiplyingFactors
        {
            get
            {
                int factor = 3;
                while (true)
                {
                    yield return factor;
                    factor = 4 - factor;
                }
            }
        }

        private static void Main()
        {
            Console.WriteLine(GetControlDigit(12345));
            Console.ReadLine();
        }
    }
}