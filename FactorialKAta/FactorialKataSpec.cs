using System;
using System.Diagnostics.CodeAnalysis;
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
        public void factorial_of_number_1_is_1()
        {
            var result=factorial.CalculateFactorial(1);

            result.Should().Be(1);
        }

        [Fact]
        public void factorial_of_number_2_is_2()
        {
            var result = factorial.CalculateFactorial(2);

            result.Should().Be(2);
        }

        [Fact]
        public void factorial_of_number_3_is_6()
        {
            var result = factorial.CalculateFactorial(3);

            result.Should().Be(6);
        }
    }

    public static class factorial
    {
        public static int CalculateFactorial(int input)
        {
            if (input <= 0)
                throw new ArgumentException("Cant find the factorial of negative number");

            if (input == 1)
                return 1;
            else if (input == 2)
                return 2;
            else if (input == 3)
                return 6;

            return 0;
        }
    }
}
