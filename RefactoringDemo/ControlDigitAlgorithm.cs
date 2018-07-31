using System;
using System.Collections.Generic;
using System.Linq;

namespace RefactoringDemo
{
    public class ControlDigitAlgorithm
    {
        private Func<long, IEnumerable<int>> GetDigitsOf { get; }
        private IEnumerable<int> MultiplyingFactors { get; }
        private int Modulo { get; }

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
