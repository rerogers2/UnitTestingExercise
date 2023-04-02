using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory] // because there are parameters in the add method
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        [InlineData(0, 0, 0, 0)]
        [InlineData(-1, -3, -4, -8)]
        [InlineData(1, -2, 3, 2)]
        [InlineData(-1, -9, 3, -7)]
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            var calculator = new Calculator();
            

            //Act
                // call the Add method that is located in the Calculator class
                // and store its result in a variable named actual
            var actual = calculator.Add(num1, num2, num3);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10, 3, 7)]//Add test data <-------
        [InlineData(3, 10, -7)]
        [InlineData(0, 0, 0)]
        [InlineData(-1, -3, 2)]
        [InlineData(-4, -1, -3)]
        [InlineData(-5, 8, -13)]
        [InlineData(4, -4, 8)]
        [InlineData(0, -2, 2)]
        [InlineData(2, 0, 2)]
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var calculator = new Calculator();

            //Act
            var actual = calculator.Subtract(minuend, subtrhend);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(2, 3, 6)]//Add test data <-------
        [InlineData(-3, -4, 12)]
        [InlineData(3, -9, -27)]
        [InlineData(-1, 2, -2)]
        [InlineData(0, 5, 0)]
        [InlineData(0, 0, 0)]
        [InlineData(-1, 0, 0)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var calculator = new Calculator();

            //Act
            var actual = calculator.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(8, 2, 4)]//Add test data <-------
        [InlineData(2, 8, 2/8)]
        [InlineData(-4, -3, 4/3)]
        [InlineData(10, -3, -10/3)]
        [InlineData(-7, 8, -7/8)]
        [InlineData(0, 0, 0)]
        [InlineData(0, 3, 0)]
        [InlineData(-5, 0, 0)]
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var calculator = new Calculator();

            //Act
            var actual = calculator.Divide(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }

    }
}
