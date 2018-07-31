using System;

namespace RefactoringDemo
{
    internal class Program
    {
        private static int GetControlDigit(long number)
        {
            var sum = 0;
            var isOddPos = true;

            while (number > 0)
            {
                var digit = (int) (number % 10);

                if (isOddPos)
                {
                    sum += 3 * digit;
                }
                else
                {
                    sum += digit;
                }

                number /= 10;
                isOddPos = !isOddPos;
            }

            var modulo = sum % 7;

            return modulo;
        }

        private static void Main()
        {
            Console.WriteLine(GetControlDigit(12345));
            Console.ReadLine();
        }
    }
}