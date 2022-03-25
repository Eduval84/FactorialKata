using System;
using System.Diagnostics.CodeAnalysis;
using Xunit;
using FluentAssertions;
using FluentAssertions.Execution;

namespace FactorialKAta
{
    public class FactorialKataSpec
    {
        [Fact]
        public void Cant_Find_The_Factorial_Of_Negative_Number()
        {
            Action act = () => factorial.Calculate_Factorial_withLoop(-1);

            act.Should().Throw<ArgumentException>().WithMessage("Cant find the factorial of negative number");
        }

        [Fact]
        public void factorial_of_number_1_is_1()
        {
            var result = factorial.Calculate_Factorial_withLoop(1);

            result.Should().Be(1);
        }

        [Fact]
        public void factorial_of_number_2_is_2()
        {
            var result = factorial.Calculate_Factorial_withLoop(2);

            result.Should().Be(2);
        }

        [Theory]
        [InlineData(3, 6)]
        [InlineData(4, 24)]
        [InlineData(5, 120)]
        public void calculate_factorial_of_numbers(int input, int expected)
        {
            var result = factorial.Calculate_Factorial_withLoop(input);

            result.Should().Be(expected);
        }

        [Theory]
        [InlineData(3, 6)]
        [InlineData(4, 24)]
        [InlineData(5, 120)]
        public void calculate_factorial_of_numbers_with_recursivity(int input, int expected)
        {
            var result = factorial.Calculate_Factorial_With_Recursivity(input);

            result.Should().Be(expected);
        }
    }

    public static class factorial
    {
        public static int Calculate_Factorial_withLoop(int input)
        {
            if (input <= 0)
                throw new ArgumentException("Cant find the factorial of negative number");

            var factorial = input;

            for (int i = input - 1; i >= 1; i--)
            {
                factorial *= i;
            }

            return factorial;
        }

        public static int Calculate_Factorial_With_Recursivity(int input)
        {
            if (input <= 0)
                throw new ArgumentException("Cant find the factorial of negative number");

            if (input == 1)
                return 1;
            else
            {
                return input * Calculate_Factorial_With_Recursivity(input - 1);
            }
        }
    }
}
