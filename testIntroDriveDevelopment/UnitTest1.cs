using Xunit;
using introTestDriveDevelopment;
using System;

namespace testIntroDriveDevelopment
{
   

    public class UnitTest1
    {
        public Calculator CalculatorConstru()
        {
            string date = "17/02/2022";
            Calculator _calculator = new Calculator(date);

            return _calculator;
        }

        [Theory]
        [InlineData(1,2,3)]
        [InlineData(12,222,234)]
        [InlineData(333,333,666)]
        [InlineData(1,0,1)]
        public void TestSum(int valOne, int valTwo, int result)
        {
            Calculator _calculator = CalculatorConstru();

            int resultCaculator = _calculator.sum(valOne,valTwo);
            Assert.Equal(result, resultCaculator);


        }

        [Theory]
        [InlineData(2, 1, 1)]
        [InlineData(222, 12, 210)]
        [InlineData(333, 33, 300)]
        [InlineData(1, 0, 1)]
        public void TestSubtract(int valOne, int valTwo, int result)
        {
            Calculator _calculator = CalculatorConstru();

            int resultCaculator = _calculator.subtract(valOne, valTwo);
            Assert.Equal(result, resultCaculator);


        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(12, 222, 2664)]
        [InlineData(333, 333, 110889)]
        [InlineData(1, 1, 1)]
        public void TestMultiply(int valOne, int valTwo, int result)
        {
            Calculator _calculator = CalculatorConstru();

            int resultCaculator = _calculator.multiply(valOne, valTwo);
            Assert.Equal(result, resultCaculator);


        }

  
        [Theory]
        [InlineData(2, 1, 2)]
        [InlineData(220, 20, 11)]
        [InlineData(333, 333, 1)]
        [InlineData(1, 1, 1)]
        public void TestDivide(int valOne, int valTwo, int result)
        {
            Calculator _calculator = CalculatorConstru();

            int resultCaculator = _calculator.divide(valOne, valTwo);
            Assert.Equal(result, resultCaculator);
            

        }

        [Fact]
        public void TestDivideZero()
        {
            Calculator _calculator = CalculatorConstru();
            Assert.Throws<DivideByZeroException>(
                () => _calculator.divide(3,0)
                );
        }

        [Fact]
        public void TestHistory()
        {
            Calculator _calculator = CalculatorConstru();

            _calculator.sum(1, 2);
            _calculator.divide(2, 1);
            _calculator.multiply(1, 2);
            _calculator.subtract(3,1);

            var listHistory = _calculator.history();

            Assert.NotEmpty(listHistory);
            Assert.Equal(3, listHistory.Count);
        }
    }
}