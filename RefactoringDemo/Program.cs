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

        private static void Main()
        {
            Console.WriteLine(ControlDigitAlgorithms.ForSalesDepartMent.GetControlDigit(12345));
            Console.WriteLine(ControlDigitAlgorithms.ForAccountingDepartment.GetControlDigit(12345));
            Console.ReadLine();
        }
    }
}