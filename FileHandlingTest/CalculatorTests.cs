using FileHandling;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FileHandlingTest
{
    [TestClass]
    public class CalculatorTests
    {
        #region Math
        [TestMethod]
        public void AdditionEqual()
        {
            //Arrange
            Calculator calc = new Calculator();
            double result;
            double expected = 45;

            //Act
            result = calc.Addition(25, 20);

            //Assert 
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void MultiplicationEqual()
        {
            //Arrange
            Calculator calc = new Calculator();
            double result;
            double expected = 20;

            //Act
            result = calc.Multiplication(5, 4);

            //Assert 
            Assert.AreEqual(result, expected);
        }
        [TestMethod]
        public void SubtractionEqual()
        {
            //Arrange
            Calculator calc = new Calculator();
            double result;
            double expected = 5;

            //Act
            result = calc.Subtraction(15, 10);

            //Assert 
            Assert.AreEqual(result, expected);
        }
        [TestMethod]
        public void DivideEqual()
        {
            //Arrange
            Calculator calc = new Calculator();
            double result;
            double expected = 7;

            //Act
            result = calc.Divide(49, 7);

            //Assert 
            Assert.AreEqual(result, expected);
        }
        #endregion
    }
}
