using MISA.WebFresher052023.Demo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISAWebFresher052023.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [TestCase(1, 2, 3)]
        [TestCase(int.MaxValue, 1, int.MaxValue + (long)1)]
        public void Add_ValidInput_ValidResult(int x, int y, long expectedResult)
        {
            //Arrange

            //Act
            var actualResult = new Calculator().Add(x, y);

            //Assert
            Assert.That(expectedResult, Is.EqualTo(actualResult));
        }

        [TestCase(3, 4, -1)]
        [TestCase(int.MaxValue, int.MinValue, int.MaxValue - (long)int.MinValue)]
        public void Sub_ValidInput_ValidResult(int x, int y, long expectedResult)
        {
            //Act
            var actualResult = new Calculator().Sub(x, y);

            //Assert
            Assert.That(expectedResult, Is.EqualTo(actualResult));
        }

        [TestCase(3, 4, 12)]
        [TestCase(3, -2, -6)]
        [TestCase(int.MaxValue, int.MinValue, int.MaxValue * (long)int.MinValue)]
        public void Mul_ValidInput_ValidResult(int x, int y, long expectedResult)
        {
            //Act
            var actualResult = new Calculator().Mul(x, y);

            //Assert
            Assert.That(expectedResult, Is.EqualTo(actualResult));
        }


        [Test]
        public void Div_DivideByZero_ReturnException()
        {
            //Arrange
            var x = 1;
            var y = 0;
            var expectedExceptionMessage = "Không chia được cho 0";

            //Act&Assert
            var exception = Assert.Throws<Exception>(() => new Calculator().Div(x, y));
            Assert.That(exception.Message, Is.EqualTo(expectedExceptionMessage));
        }

        [TestCase(2, 3, (double)2/3)]
        [TestCase(2, 3, 0.66666)]
        public void Div_ValidInput_ValidResult(int x, int y, double expectedResult)
        {
            //Act
            var actualResult = new Calculator().Div(x, y);

            //Assert
            Assert.That(Math.Abs(actualResult - expectedResult), Is.LessThan(1e-4));
        }

        [TestCase("")]
        public void Add_EmptyString_ReturnsZero(string input)
        {
            // Act
            var result = new Calculator().Add(input);

            // Assert
            Assert.AreEqual(0, result);
        }

        [Test]
        public void Add_NegativeNumber_ReturnsZero()
        {
            //Arrange
            string input = "-1, 3, -2";
            string expectedResult = "-1, -2";
            var expectedExceptionMessage = $"Không chấp nhận toán tử âm: {expectedResult}";
            // Act&Assert
            var exception = Assert.Throws<Exception>(() => new Calculator().Add(input));
            Assert.That(exception.Message, Is.EqualTo(expectedExceptionMessage));
        }

        [TestCase("1, 2, 4", 7)]
        public void Add_PositiveNumber_ReturnSum(string input, int expectedResult)
        {
            // Act
            var actualResult = new Calculator().Add(input);

            // Assert
            Assert.That(expectedResult, Is.EqualTo(actualResult));
        }

    }
}
