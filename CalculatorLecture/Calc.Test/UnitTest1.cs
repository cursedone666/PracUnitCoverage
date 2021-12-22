using System;
using Xunit;
using CalculatorLecture;

namespace Calc.Test
{
    public class UnitTest1
    {
        [InlineData(2.55,2.34,4.89)]
        [InlineData(-200.2478,-666.5689,-866.8167)]
        [InlineData(-1.111,1.111,0)]

        [Theory]
        public void AddTest(double a, double b, double expectedResult)
        {
            double actual = MathOperations.Add(a,b);
            Assert.Equal(expectedResult, actual);
        }


        [InlineData(10,5,5)]
        [InlineData(-250,-250,0)]
        [InlineData(-150.75,220.374,-371.124)]
        [Theory]
        public void SubTest(double a, double b, double expectedResult)
        {
            double actual = MathOperations.Substraction(a,b);
            Assert.Equal(expectedResult, actual);
        }

        [InlineData(5,5.58,27.9)]
        [InlineData(-3,10,-30)]      
        [InlineData(0,0,0)]
        [Theory]
        public void MultiplyTest(double a, double b, double expectedResult)
        {
            double actual = MathOperations.Multiply(a,b);
            Assert.Equal(expectedResult, actual);
        }

        [InlineData(12,2,6)]
        [InlineData(-24,-2,12)]
        [InlineData(-30,5,-6)]
        
        [Theory]
        public void DivisionTest(double a, double b, double expectedResult)
        {
            double actual = MathOperations.Division(a,b);
            Assert.Equal(expectedResult, actual);
        }

        [Fact]
        public void DivisionByZeroTest()
        {
            
            double a = 12;
            double b = 0;
            Action act = () => MathOperations.Division(a,b);
            Assert.Throws<DivideByZeroException>(act);
            //Assert.ThrowsAsync<DivideByZeroException>(() =>  throw new DivideByZeroException("ZERO DIVISION") );
        }

        [Fact]
        public void NegativeInSquareRoot()
        {
            
            double a = -12;           
            Action act = () => MathOperations.SquareRoot(a);
            Assert.Throws<ArithmeticException>(act);
            //Assert.ThrowsAsync<ArgumentException>(() => throw new ArgumentException("Root can't be less then 0"));
        }



        [InlineData(25,5)]
        [InlineData(0,0)]
        
        [Theory]
        public void SquareRootTest(double a, double expectedResult)
        {
            double actual = MathOperations.SquareRoot(a);
            Assert.Equal(expectedResult, actual);
        }
    }
}
