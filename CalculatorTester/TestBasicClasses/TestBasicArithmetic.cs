using Xunit;
using Calculator;
using System;
namespace CalculatorTester.TestBasicClasses
{
    public class TestBasicArithmetic
    {
        [Fact]
        public void CanAddBasicTestCase()
        {
            //arrange 
            var arithmetic = new BasicArithmetic();
            //act 
            var result = arithmetic.add(5, 6);        
            //assert
            Assert.True(result == 11);  
        }

        [Theory]
        [InlineData(5.55, 5.66, 11.21)]
        [InlineData(6.888,9.777,16.665)]
        public void AddFunctionMustReturnValidAnswer(float arg1, float arg2, float ExpectedResult )
        {
            //arrange 
            float difference = Math.Abs(1 * .0001f);
            var arithmetic = new BasicArithmetic();
            //act 
            var ActualResult = arithmetic.add(arg1, arg2);         
            //assert
            Assert.True(Math.Abs(ActualResult - (float) ExpectedResult) <= difference);   
        }

        [Fact]
        public void DivideByZeroMustThrowException()
        {
            //arrange 
            var arithmetic = new BasicArithmetic();
            //act 
            var result = arithmetic.divide(5, 0);
            //assert
            Assert.Throws<DivideByZeroException>(() => arithmetic.divide(5, 0));     
        }
        
    }
    
    
}