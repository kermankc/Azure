using System;
using System.Linq;
using BL;
using Xunit;

namespace Tests
{
    public class Numbers
    {
        [Theory]
        [InlineData(new[]{1,1},2)]
        [InlineData(new[]{1,2},3)]
        [InlineData(new[]{1000,100},1100)]
        [InlineData(new[]{1,1,1,1,1,1,1},7)]
        public void AddNumbers(int[] numbers, int expected)
        {
            var result = Calculator.Add(numbers);
            Assert.Equal(result, expected);

        }
        
        [Theory]
        [InlineData(new[]{1,1},0)]
        [InlineData(new[]{1,2},-1)]
        [InlineData(new[]{1000,100},900)]
        [InlineData(new[]{1,1,1,1,1,1,1},-5)]
        public void SubtractNumbers(int[] numbers, int expected)
        {
            var result = Calculator.Subtract(numbers);
            Assert.Equal(result, expected);

        }
        
        [Theory]
        [InlineData(new[]{1,1},1)]
        [InlineData(new[]{1,1, 1, 1,0, 1,},0)]
        [InlineData(new[]{1,2},2)]
        [InlineData(new[]{1000,100},100000)]
        [InlineData(new[]{1,1,1,1,1,1,1},1)]
        public void MultiplyNumbers(int[] numbers, int expected)
        {
            var result = Calculator.Multiply(numbers);
            Assert.Equal(result, expected);
        }
        
        [Theory]
        [InlineData(new []{1f,1},1f)]
        [InlineData(new[]{1f,1, 1, 1, 1,},1f)]
        [InlineData(new[]{1f,2},0.5f)]
        [InlineData(new[]{1000f,100},10f)]
        [InlineData(new[]{1f,1,1,1,1,1,2}, 0.5f)]
        public void DivideNumbers(float[] numbers, float expected)
        {
            var result = Calculator.Divide(numbers);
            Assert.Equal(result, expected);
        }
    }
}