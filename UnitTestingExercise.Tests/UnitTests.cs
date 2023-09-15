  using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            var test = new Calculator();


            //Act
            var actual = test.Add(num1, num2, num3);

            //Assert
                Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10, 4, 6)]//Add test data <-------
        public void SubtractTest(int minuend, int subtrend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var test1 = new Calculator();

            //Act
            var actual = test1.Subtract(minuend, subtrend);


            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2, 2, 4)]//Add test data <-------
        public void MultiplyTest(int number1, int number2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var test2 = new Calculator();

            //Act
            var actual = test2.Multiply(number1, number2);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(6, 2, 3)]//Add test data <-------
        public void DivideTest(int numero1, int numero2, int expected)
        {
            //Arrange
            var test3 = new Calculator();

            //Act
            var actual = test3.Divide(numero1, numero2);

            //Assert
            Assert.Equal(expected, actual); 
        }

    }
}
