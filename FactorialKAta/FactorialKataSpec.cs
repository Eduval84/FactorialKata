using System;
using Xunit;
using FluentAssertions;

namespace FactorialKAta
{
    public class FactorialKataSpec
    {
        [Fact]
        public void Cant_Find_The_Factorial_Of_Negative_Number()
        {
            Action act = () => factorial.CalculateFactorial(-1);

            act.Should().Throw<ArgumentException>().WithMessage("Cant find the factorial of negative number");
        }

        [Fact]
        public void factorial_of_number_one_is_one()
        {
            var result=factorial.CalculateFactorial(1);

            result.Should().Be(1);
        }

    }

    public static class factorial
    {
        public static int CalculateFactorial(int i)
        {
            if (i == 1)
                return 1;
            throw new ArgumentException("Cant find the factorial of negative number");
        }
    }
}
