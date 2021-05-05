using Calculator.Api.Domain;
using FluentAssertions;
using Xunit;

namespace Calculator.Api.UnitTests
{
    public class CalculatorTests
    {
        [Theory]
        [InlineData("1+1", 2)]
        public void Positive(string expression, int expectedResult)
        {
            var actualResult = CalculatorExecutor.Calculate(expression);
            actualResult.Should().Be(expectedResult);
        }
    }
}