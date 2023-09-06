namespace UnitTest.NUnitTest.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
        [Test] 
        public void MultiplicationNotNull() 
        {

            var calc = new Calculator();
            Assert.AreEqual(8, calc.Multiplication(2, 4));
            //Assert.That(1 == 0.1);
        }
        [Test]
        public void SubstructionTest()
        {
            var calc = new Calculator();
            Assert.AreEqual(-2, calc.Subtraction(2, 4));

        }
        [Test]
        public void DivisionNotNull()
        {

            var calc = new Calculator();
            //Assert.AreEqual(0, calc.Division(2, 4));
            Assert.That(calc.Division(23, 4) == 5);
        }
        [Test]
        public void DivisionByZeroException()
        {

            var calc = new Calculator();
            Assert.Throws<DivideByZeroException>(() => calc.Division(23, 0));
        }
    }
}