using System;
using System.Collections.Generic;
using System.Linq;

namespace RefactoringDemo
{
    public class ControlDigitAlgorithm
    {
        public Func<long, IEnumerable<int>> GetDigitsOf { get; }
        public IEnumerable<int> MultiplyingFactors { get; }
        public int Modulo { get; }

        public ControlDigitAlgorithm(Func<long, IEnumerable<int>> digitsOf, IEnumerable<int> multiplyingFactors, int modulo)
        {
            GetDigitsOf = digitsOf;
            MultiplyingFactors = multiplyingFactors;
            Modulo = modulo;
        }

        public int GetControlDigit(long number) =>
            GetDigitsOf(number)
                .Zip(MultiplyingFactors, (a, b) => a * b)
                .Sum()
                % Modulo;
    }
}
