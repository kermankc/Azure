using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace BL
{
    public static class Calculator
    {
        public static int Add(IEnumerable<int> numbers)
        {
            return numbers.Sum(x => x);
        }

        public static int Subtract(IEnumerable<int> numbers)
        {
            return numbers.Skip(1).Aggregate(numbers.First(), (acc, next) => acc - next);
        }

        public static int Multiply(IEnumerable<int> numbers)
        {
            return numbers.Aggregate(1, (acc, next) => acc * next);
        }

        public static float Divide(IEnumerable<float> numbers)
        {
            return  numbers.Skip(1).Aggregate(numbers.First(), (acc, next) => acc / next);
        }
    }
}