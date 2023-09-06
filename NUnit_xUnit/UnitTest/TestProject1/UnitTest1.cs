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
        [Fact]
        public void SubstructionTestNotNull()
        {
            var calc = new Calculator();
            Assert.Equal(-2, calc.Subtraction(2, 4));
        }
        [Fact]
        public void DivisionNotNull()
        {

            var calc = new Calculator();
            //Assert.AreEqual(0, calc.Division(2, 4));
            Assert.True(calc.Division(23, 4) == 5);
        }
        [Fact]
        public void DivisionByZeroException()
        {

            var calc = new Calculator();
            //Assert.AreEqual(0, calc.Division(2, 4));
            Assert.Throws<DivideByZeroException>(() => calc.Division(23, 0));
        }
    }
}