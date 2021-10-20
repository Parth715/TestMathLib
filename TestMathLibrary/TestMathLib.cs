using MathLibrary;
using System;
using Xunit;

namespace TestMathLibrary
{
    public class TestMathLib
    {
        [Theory]
        [InlineData(27, 9, 3)]
        [InlineData(50, 5, 10)]
        [InlineData(84, 7, 12)]
        [InlineData(35, 7, 5)]
        [InlineData(-144, -12, 12)]
        [InlineData(0, 0, 129)]
        public void TestMultiply(int ans, int a, int b)
        {
            Assert.Equal(ans, MathLib.Multiply(a, b));
        }

        [Theory]
        [InlineData(3, 1, 2)]
        [InlineData(-3, -1, -2)]
        public void TestAdd(int ans, int a, int b)
        {
            Assert.Equal(ans, MathLib.Add(a, b));
        }

        [Fact]
        public void TestPI()
        {
            Assert.Equal(3.1415927m, MathLib.PI);
        }
    }
}
