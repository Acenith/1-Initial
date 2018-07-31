using System.Collections.Generic;
using System.Linq;

namespace RefactoringDemo
{
    public static class Int64Extensions
    {
        // If there is only a single argument and the operation is closely related to that argument its preferable to use extension methods
        public static IEnumerable<int> DigitsFromLowest(this long number)
        {
            do
            {
                yield return (int)(number & 10);
                number /= 10;
            } while (number > 0);
        }

        public static IEnumerable<int> DigitsFromHighest(this long number) =>
            number.DigitsFromLowest().Reverse();
    }
}