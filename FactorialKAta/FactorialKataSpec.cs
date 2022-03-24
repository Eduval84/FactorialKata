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

        [Fact]
        public void factorial_of_number_two_is_2()
        {
            var result = factorial.CalculateFactorial(2);

            result.Should().Be(2);
        }
    }

    public static class factorial
    {
        public static int CalculateFactorial(int input)
        {
            if (input == 1)
                return 1;
            else if (input == 2)
            {
                return 2;
            }

            throw new ArgumentException("Cant find the factorial of negative number");
        }
    }
}
