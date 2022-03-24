using System;
using Xunit;
using FluentAssertions;

namespace FactorialKAta
{
    public class FactorialKataSpec
    {
        [Fact]
        public void CantFindTheFactorialOfNegativeNumber()
        {
            Action act = () => factorial.CalculateFactorial(-1);

            act.Should().Throw<ArgumentException>().WithMessage("Cant find the factorial of negative number");
        }
    }

    public static class factorial
    {
        public static void CalculateFactorial(int i)
        {
            throw new NotImplementedException();
        }
    }
}
