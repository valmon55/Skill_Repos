namespace TDD.Task_4_3.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void AdditionalMustReturnCorrectValue()
        {
            var calculator = new Calculator();
            int result = calculator.Addition(50, 10, 34);
            Assert.Equal(94, result);
        }

        [Fact]
        public void MultiplicationMustReturnCorrectValue()
        {
            var calculator = new Calculator();
            int result = calculator.Multiplication(3, 2, 20);
            Assert.Equal(120, result);
        }
    }
}