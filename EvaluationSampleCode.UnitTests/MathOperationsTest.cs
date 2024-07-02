using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationSampleCode.UnitTests
{
    [TestClass]
    public class MathOperationsTest
    {

        private MathOperations _mathOperations;

        [TestInitialize]
        public void Init()
        {
            _mathOperations = new MathOperations();
        }

        [TestMethod]
        [DataRow(15, 10, 5)]
        [DataRow(40, 5, 35)]
        [DataRow(1199, 1, 1198)]
        public void Subtract_WhenCalledWithValidNumbers_ReturnsResult(int numberOne, int numberTwo, int expectedResult)
        {
            var result = _mathOperations.Subtract(numberOne, numberTwo);
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        [DataRow(20, 30)]
        public void Subtract_NumberTwoHigherThanNumberOne_ThrowsException(int numberOne, int numberTwo)
        {
            Assert.ThrowsException<ArgumentException>(() => _mathOperations.Subtract(numberOne, numberTwo));
        }

        [TestMethod]
        [DataRow(1201, 30)]
        [DataRow(23455, 1)]
        public void Subtract_NumberOneHigherThanLimit_ThrowsException(int numberOne, int numberTwo)
        {
            Assert.ThrowsException<ArgumentException>(() => _mathOperations.Subtract(numberOne, numberTwo));
        }

        [TestMethod]
        [DataRow(1, "Blue")]
        [DataRow(99, "Blue")]
        public void GetColorFromOddNumber_OddNumber_ReturnsBlue(int number, string expectedColor)
        {
            var result = _mathOperations.GetColorFromOddsNumber(number);
            Assert.AreEqual(result, expectedColor);
        }

        [TestMethod]
        [DataRow(8, "Red")]
        [DataRow(350, "Red")]
        public void GetColorFromOddNumber_EvenNumber_ReturnsRed(int number, string expectedColor)
        {
            var result = _mathOperations.GetColorFromOddsNumber(number);
            Assert.AreEqual(result, expectedColor);
        }


        [TestMethod]
        [DataRow(-10)]
        public void GetColorFromOddNumber_NegativeNumber_ThrowsException(int number)
        {
            Assert.ThrowsException<ArgumentException>(() => _mathOperations.GetColorFromOddsNumber(number));
        }

    }
}
