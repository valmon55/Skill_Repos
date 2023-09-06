namespace UnitTest.xUnitTest.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void MultiplicationTestNotnull()
        {
            var calc = new Calculator();
            Assert.Equal(8, calc.Multiplication(2, 4));
        }
    }
}