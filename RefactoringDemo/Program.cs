using System;

namespace RefactoringDemo
{
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine(ControlDigitAlgorithms.ForSalesDepartMent.GetControlDigit(12345));
            Console.WriteLine(ControlDigitAlgorithms.ForAccountingDepartment.GetControlDigit(12345));
            Console.ReadLine();
        }
    }
}